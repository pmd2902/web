using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaoCaoLTW.Models.BUS
{
    public class ThuongHieuBUS
    {
        public static IEnumerable<NhaSanXuat> DanhSach()
        {
            var data = new ShopGiaydbContextDataContext();
            return data.NhaSanXuats.Where(x => x.TinhTrang == true);
        }
    }
}