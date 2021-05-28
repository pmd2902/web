using BaoCaoLTW.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaoCaoLTW.Controllers
{
    public class ShopController : Controller
    {
        ShopGiaydbContextDataContext data = new ShopGiaydbContextDataContext();
        // GET: Shop


        public List<SanPham> ListSanPham()
        {
            return data.SanPhams.Where(x => x.TinhTrang == true).ToList();
        }

        public ActionResult Shop(int page = 1, int pagesize = 4)
        {
            var sanpham = ListSanPham().ToPagedList(page, pagesize);
            return View(sanpham);
        }

        

        
    }
}