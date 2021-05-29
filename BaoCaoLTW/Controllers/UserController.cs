using BaoCaoLTW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaoCaoLTW.Controllers
{
   
        public class UserController : Controller
        {
            ShopGiaydbContextDataContext data = new ShopGiaydbContextDataContext();
            // GET: User
            public ActionResult Index()
            {
                return View();
            }
            [HttpGet]
            public ActionResult Register()
            {
                return View();
            }
            [HttpPost]
            public ActionResult Register(FormCollection col, KhachHang kh)
            {
                var hoten = col["HotenKH"];
                var tendn = col["TenDN"];
                var matkhau = col["Matkhau"];
                var matkhaunhaplai = col["Matkhaunhaplai"];
                var email = col["Email"];
                var diachi = col["Diachi"];
                var dienthoai = col["Dienthoai"];
                var ngaysinh = String.Format("{0:MM/dd/yyyy}", col["Ngaysinh"]);
                if (String.IsNullOrEmpty(hoten))
                {
                    ViewData["Loi1"] = "Chưa nhập họ tên";
                }
                else if (String.IsNullOrEmpty(tendn))
                {
                    ViewData["Loi2"] = "Chưa nhập tên đăng nhập";
                }
                else if (String.IsNullOrEmpty(matkhau))
                {
                    ViewData["Loi3"] = "Chưa nhập mật khẩu";
                }
                else if (String.IsNullOrEmpty(matkhaunhaplai))
                {
                    ViewData["Loi4"] = "Chưa nhập mật khẩu nhập lại";
                }
                else if (String.IsNullOrEmpty(email))
                {
                    ViewData["Loi5"] = "Chưa nhập Email";
                }
                else if (String.IsNullOrEmpty(diachi))
                {
                    ViewData["Loi6"] = "Chưa nhập địa chỉ";
                }
                else if (String.IsNullOrEmpty(dienthoai))
                {
                    ViewData["Loi7"] = "Chưa nhập SĐT";
                }
                else
                {
                    kh.HoTen = hoten;
                    kh.TaiKhoan = tendn;
                    kh.MatKhau = matkhau;
                    kh.Email = email;
                    kh.DiaChiKH = diachi;
                    kh.DienThoaiKH = dienthoai;
                    kh.NgaySinh = DateTime.Parse(ngaysinh);
                    data.KhachHangs.InsertOnSubmit(kh);
                    data.SubmitChanges();
                    return RedirectToAction("Login");
                }
                return this.Register();
            }
            [HttpGet]
            public ActionResult Login()
            {
                return View();
            }
            [HttpPost]
            public ActionResult Login(FormCollection col)
            {
                var tendn = col["tenDN"];
                var matkhau = col["matkhau"];
                if (String.IsNullOrEmpty(tendn))
                {
                    ViewData["Loi1"] = "Chưa nhập tài khoản";
                }
                else if (String.IsNullOrEmpty(matkhau))
                {
                    ViewData["Loi2"] = "Chưa nhập mật khẩu";
                }
                else
                {
                    KhachHang kh = data.KhachHangs.Where(x => x.TaiKhoan == tendn && x.MatKhau == matkhau).FirstOrDefault();
                    if (kh != null)
                    {
                        ViewBag.Thongbao = "Đăng nhập thành công";
                        Session["Taikhoan"] = kh;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Thongbao = "Mật khẩu hoặc tài khoản không đúng vui lòng nhập lại";
                    }
                }
                return View();
            }
            public ActionResult LogOut()
            {
                Session["Taikhoan"] = null;
                return RedirectToAction("Index", "Home");
            }
            public ActionResult profileUser()
            {
                KhachHang kh = (KhachHang)Session["Taikhoan"];
                return View(kh);
            }         
        }
}