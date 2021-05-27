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
            return View(sanpham.Single());
        }

    }
}