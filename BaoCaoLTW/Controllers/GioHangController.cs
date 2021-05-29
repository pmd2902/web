using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaoCaoLTW.Models;

namespace BaoCaoLTW.Controllers
{
    public class GioHangController : Controller
    {
        ShopGiaydbContextDataContext data = new ShopGiaydbContextDataContext();
        // GET: GioHang
        public List<GioHang> LayGioHang()
        {
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang == null)
            {
                lstGioHang = new List<GioHang>();
                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
        }

        public ActionResult ThemGioHang(string sMaSanPham, string strURL)
        {
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.Find(n => n.sMaSanPham == sMaSanPham);
            if (sanpham == null)
            {
                sanpham = new GioHang(sMaSanPham);
                lstGioHang.Add(sanpham);
                return RedirectToAction("GioHang", "GioHang");
            }
            else
            {
                sanpham.iSoLuong++;
                return RedirectToAction("GioHang", "GioHang");
            }
        }

        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                iTongSoLuong = lstGioHang.Sum(n => n.iSoLuong);
            }
            return iTongSoLuong;
        }
        private double TongTien()
        {
            double iTongTien = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                iTongTien = lstGioHang.Sum(n => n.dThanhTien);
            }
            return iTongTien;
        }

        public ActionResult GioHang()
        {
            List<GioHang> lstGioHang = LayGioHang();
            if (lstGioHang.Count == 0)
            {
                return RedirectToAction("GioHang", "GioHang");
            }
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = TongTien();
            return View(lstGioHang);
        }

        public ActionResult GioHangPartial()
        {
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = TongTien();
            return PartialView();
        }

        public ActionResult XoaGioHang(string sMaSP)
        {
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.SingleOrDefault(n => n.sMaSanPham == sMaSP);
            if (sanpham != null)
            {
                lstGioHang.Remove(sanpham);
                return RedirectToAction("GioHang");
            }
            if (lstGioHang.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("GioHang");
        }

        public ActionResult CapNhatGioHang(string sMaSP, FormCollection f)
        {
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.SingleOrDefault(n => n.sMaSanPham == sMaSP);
            if (sanpham != null)
            {
                sanpham.iSoLuong = int.Parse(f["txtSoLuong"].ToString());
            }
            return RedirectToAction("GioHang");
        }

        public ActionResult XoaTatCaGioHang()
        {
            List<GioHang> lstGioHang = LayGioHang();
            lstGioHang.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult DatHang()
        {
            //Kiểm tra đăng nhập
            if (Session["Taikhoan"] == null || Session["Taikhoan"].ToString() == "")
            {
                return RedirectToAction("Login", "User");
            }
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //Lấy giỏ hàng từ sesion
            List<GioHang> list = LayGioHang();
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Thanhtien = TongTien();
            return View(list);
        }
        public ActionResult DatHang(FormCollection fcol)
        {
            //Thêm đơn hàng
            LichSuMuaHang ddh = new LichSuMuaHang();
            KhachHang kh = (KhachHang)Session["Taikhoan"];
            List<GioHang> gList = LayGioHang();
            ddh.ID = kh.ID;
            ddh.HoTen = kh.HoTen;
            ddh.DiaChiKH = kh.DiaChiKH;
            ddh.DienThoaiKH = kh.DienThoaiKH;
            ddh.NgayDat = DateTime.Now;
            var Ngaygiao = String.Format("{0:MM/dd/yyyy}", fcol["Ngaygiao"]);
            ddh.NgayDat = DateTime.Parse(Ngaygiao);
            ddh.TinhTrang = false;           
            data.LichSuMuaHangs.InsertOnSubmit(ddh);
            data.SubmitChanges();
            foreach (var item in gList)
            {
                ChiTietDonHang ctdh = new ChiTietDonHang();
                ctdh.MaDonHang = ddh.MaDonHang;
                ctdh.MaSanPham = item.sMaSanPham;
                ctdh.SoLuong = item.iSoLuong;
                ctdh.Gia = item.iGia;
                data.ChiTietDonHangs.InsertOnSubmit(ctdh);
                var soluong = data.SanPhams.SingleOrDefault(x => x.MaSanPham == ctdh.MaSanPham);                
                data.SubmitChanges();
            }
            data.SubmitChanges();
            Session["Giohang"] = null;
            return RedirectToAction("Xacnhandondathang", "GioHang");
        }
        public ActionResult Xacnhandondathang()
        {
            return View();
        }
    }
}