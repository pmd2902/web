using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaoCaoLTW.Models;

namespace BaoCaoLTW.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ShopGiaydbContextDataContext data = new ShopGiaydbContextDataContext();

        public List<SanPham> Laysanpham(int count)
        {          
            return data.SanPhams.Where(x => x.TinhTrang == true).Take(count).ToList();
        }

        public ActionResult Index()
        {
            var sanpham = Laysanpham(3);
            return View(sanpham);
        }

        public ActionResult Detail(string id)
        {
            var sanpham = from s in data.SanPhams
                          where s.MaSanPham == id
                          select s;
            return View(sanpham.SingleOrDefault());
        }

        public ActionResult ThuongHieu()
        {
            var thuonghieu = from th in data.NhaSanXuats select th;
            return PartialView(thuonghieu);
        }

        public ActionResult SPTheoThuongHieu(string id)
        {
            var sanpham = from s in data.SanPhams where s.MaNhaSX == id select s;
            return View(sanpham);
        }

        public ActionResult donHang()
        {
            if (Session["Taikhoan"] == null)
            {
                return RedirectToAction("Login", "User");
            }
            else
            {
                KhachHang kh = (KhachHang)Session["Taikhoan"];
                List<LichSuMuaHang> ddh = data.LichSuMuaHangs.Where(x => x.ID == kh.ID).ToList();
                return View(ddh);
            }
        }
        private int iTongsoluong(int MaDH)
        {
            int iTongsoluong = 0;
            List<ChiTietDonHang> list = data.ChiTietDonHangs.Where(x => x.MaDonHang == MaDH).ToList();
            if (list != null)
            {
                iTongsoluong = (int)list.Sum(x => x.SoLuong);
            }
            return iTongsoluong;
        }

        private double dTongtien(int MaDH)
        {
            double dTongtien = 0;
            List<ChiTietDonHang> list = data.ChiTietDonHangs.Where(x => x.MaDonHang == MaDH).ToList();
            if (list != null)
            {
                dTongtien = (double)list.Sum(x => x.SoLuong * x.Gia);
            }
            return dTongtien;
        }

        public ActionResult CTDDH(int MaDH)
        {
            List<ChiTietDonHang> ctdhlist = data.ChiTietDonHangs.Where(x => x.MaDonHang == MaDH).ToList();
            ViewBag.Tongsoluong = iTongsoluong(MaDH);
            ViewBag.Tongtien = dTongtien(MaDH);
            return View(ctdhlist);
        }




    }
}