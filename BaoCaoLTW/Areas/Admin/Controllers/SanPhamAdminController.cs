using BaoCaoLTW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaoCaoLTW.Areas.Admin.Controllers
{

    public class SanPhamAdminController : Controller
    {
        ShopGiaydbContextDataContext data = new ShopGiaydbContextDataContext();
        // GET: Admin/SanPhamAdmin
        public ActionResult Index()
        {
            var sanpham = data.SanPhams.ToList();

            return View(sanpham);
        }

        // GET: Admin/SanPhamAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        // GET: Admin/SanPhamAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/SanPhamAdmin/Create
        [HttpPost]
        public ActionResult Create(SanPham sanpham)
        {
            var res = data.SanPhams.Any(x => x.MaSanPham == sanpham.MaSanPham);
            if (res)
            {
                ModelState.AddModelError("", "Mã này đã tồn tại");
                return View();
            }
            else
            {
                data.SanPhams.InsertOnSubmit(sanpham);
                data.SubmitChanges();
            }

            return RedirectToAction("Index");

        }
        // GET: Admin/SanPhamAdmin/Edit/5
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var sanpham = data.SanPhams.SingleOrDefault(x => x.MaSanPham == id);
            return View(sanpham);

        }

        // POST: Admin/NhaSanXuatAdmin/Create
        [HttpPost]
        public ActionResult Edit(SanPham sanpham)
        {
            var sp = data.SanPhams.SingleOrDefault(x => x.MaSanPham == sanpham.MaSanPham);
            sp.MaSanPham = sanpham.MaSanPham;
            sp.TenSanPham = sanpham.TenSanPham;
            sp.HinhAnh = sanpham.HinhAnh;
            sp.MaNhaSX = sanpham.MaNhaSX;
            sp.TenNhaSX = sanpham.TenNhaSX;
            sp.Gia = sanpham.Gia;
            sp.SoLuong = sanpham.SoLuong;
            sp.TinhTrang = sanpham.TinhTrang;
            data.SubmitChanges();

            return RedirectToAction("Index");
        }

        // POST: Admin/SanPhamAdmin/Delete/5
        //[HttpPost]C:\Users\dell\Desktop\MVC 1\web\BaoCaoLTW\Areas\Admin\Views\NhaSanXuatAdmin\Index.cshtml
        public ActionResult Delete(string id)
        {
            ShopGiaydbContextDataContext data = new ShopGiaydbContextDataContext();
            SanPham sp = data.SanPhams.FirstOrDefault(x => x.MaSanPham == id);
            if (sp != null)
            {
                data.SanPhams.DeleteOnSubmit(sp);
                data.SubmitChanges();
            }

            return RedirectToAction("Index");
        }

    }
}

