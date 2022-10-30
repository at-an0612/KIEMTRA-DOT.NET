using buoi3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3
{
    internal class GiangVien
    {
        public string MaGiangVien { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string GioiTinhStr
        {
            get
            {
                return GioiTinh ? "nam" : "nu";
            }
        }
        public string QueQuan { get; set; }
        public int MaKhoa { get; set; }

        public static List<GiangVien> getAll()
        {
            var List = new List<GiangVien>();
            var Lskhoa = KhoaViewModel.getList();
            Random r = new Random();
            foreach (var khoa in Lskhoa)
            {
                for (int i = 0; i < 10; i++)
                {
                    var random = r.Next(1);
                    List.Add(new GiangVien
                    {
                        MaGiangVien = $"{khoa.MaKhoa}{i}",
                        Ho = "Nguyen",
                        Ten = $"{khoa.TenKhoa}_{i}",
                        GioiTinh = (random == 0 ? true : false),
                        NgaySinh = DateTime.Now,
                        MaKhoa = khoa.MaKhoa,
                        QueQuan = "tthue"
                    });
                }
            }
            return List;
        }
        public static List<GiangVien> getByKhoa(int makhoa)
        {
            var list = getAll();
            var result = list.Where(testc => testc.MaKhoa == makhoa).ToList();
            return result;
        }
    }
}

