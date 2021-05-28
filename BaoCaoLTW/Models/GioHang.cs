using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaoCaoLTW.Models
{
    public class GioHang
    {
        ShopGiaydbContextDataContext data = new ShopGiaydbContextDataContext();
        public string sMaSanPham { get; set; }
        public string sTenSanPham { get; set; }
        public string sHinhAnh { get; set; }
        public int iGia { get; set; }
        public int iSoLuong { get; set; }
        public Double dThanhTien
        {
            get { return iSoLuong * iGia; }
        }

        public GioHang(string MaSanPham)
        {
            sMaSanPham = MaSanPham;
            SanPham sp = data.SanPhams.Single(n => n.MaSanPham == sMaSanPham);
            sTenSanPham = sp.TenSanPham;
            sHinhAnh = sp.HinhAnh;
            iGia = int.Parse(sp.Gia.ToString());
            iSoLuong = 1;
        }
    }

    
}