using BaoCaoLTW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaoCaoLTW.Controllers
{
    public class NhaSanXuatController : Controller
    {
        ShopGiaydbContextDataContext data = new ShopGiaydbContextDataContext();
        // GET: NhaSanXuat
        public List<SanPham> Laysanpham()
        {           
            return data.SanPhams.Where(x => x.TinhTrang == true).ToList();
        }

        public ActionResult Index()
        {
            var sanpham = Laysanpham();
            return View(sanpham);
        }

        public ActionResult Detail(string id)
        {
            var sanpham = from s in data.SanPhams
                          where s.MaSanPham == id
                          select s;
            return View(sanpham.SingleOrDefault());
        }
    }
}