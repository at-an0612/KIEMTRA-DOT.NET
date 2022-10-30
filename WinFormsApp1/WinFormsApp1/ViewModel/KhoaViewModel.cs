using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3
{
    internal class KhoaViewModel
    {
        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public static List<KhoaViewModel> getList()
        {
            var list = new List<KhoaViewModel>();
            list.Add(new KhoaViewModel { MaKhoa = 1, TenKhoa = "CNTT" });
            list.Add(new KhoaViewModel { MaKhoa = 2, TenKhoa = "Văn" });
            list.Add(new KhoaViewModel { MaKhoa = 3, TenKhoa = "Báo chí" });
            list.Add(new KhoaViewModel { MaKhoa = 4, TenKhoa = "Truyền thông" });
            list.Add(new KhoaViewModel { MaKhoa = 5, TenKhoa = "Ngoại ngữ" });
            list.Add(new KhoaViewModel { MaKhoa = 6, TenKhoa = "Du lịch" });
            list.Add(new KhoaViewModel { MaKhoa = 7, TenKhoa = "Hóa học" });
            return list;

        }
    }
}

