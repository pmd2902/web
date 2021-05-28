using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using System.Web.Mvc;
using BaoCaoLTW.Models;


namespace BaoCaoLTW.Areas.Admin.Controllers
{
    public class NhaSanXuatAdminController : Controller
    {
        ShopGiaydbContextDataContext data = new ShopGiaydbContextDataContext();

        // GET: Admin/NhaSanXuatAdmin
        public ActionResult Index()
        {
            var nhasanxuat = data.NhaSanXuats.ToList();

            return View(nhasanxuat);
        }

        // GET: Admin/NhaSanXuatAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        // GET: Admin/NhaSanXuatAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/NhaSanXuatAdmin/Create
        [HttpPost]
        public ActionResult Create(NhaSanXuat nhasanxuat)
        {
            var res = data.NhaSanXuats.Any(x => x.MaNhaSX == nhasanxuat.MaNhaSX);
            if (res)
            {
                ModelState.AddModelError("", "Mã này đã tồn tại");
                return View();
            }
            else
            {
                data.NhaSanXuats.InsertOnSubmit(nhasanxuat);
                data.SubmitChanges();
            }

            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var nhasanxuat = data.NhaSanXuats.SingleOrDefault(x => x.MaNhaSX == id);
            return View(nhasanxuat);

        }

        // POST: Admin/NhaSanXuatAdmin/Create
        [HttpPost]
        public ActionResult Edit(NhaSanXuat nhasanxuat)
        {
            var nsx = data.NhaSanXuats.SingleOrDefault(x => x.MaNhaSX == nhasanxuat.MaNhaSX);
            nsx.TenNhaSX = nhasanxuat.TenNhaSX;
            data.SubmitChanges();

            return RedirectToAction("Index");
        }




        // GET: Admin/NhaSanXuatAdmin/Edit/5

        public ActionResult Delete(string id)
        {
            ShopGiaydbContextDataContext data = new ShopGiaydbContextDataContext();
            List<SanPham> sp = data.SanPhams.Where(x => x.MaNhaSX == id).ToList();
            NhaSanXuat nsx = data.NhaSanXuats.FirstOrDefault(x => x.MaNhaSX == id);

            if (nsx != null)
            {
                foreach (var item in sp)
                {
                    data.SanPhams.DeleteOnSubmit(item);
                    data.SubmitChanges();
                }
                data.NhaSanXuats.DeleteOnSubmit(nsx);
                data.SubmitChanges();
            }

            return RedirectToAction("Index");
        }

    }
}

