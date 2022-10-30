using AppQLSV2.Model;
using AppQLSV2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQLSV2.Services
{
    public class SinhVienService
    {
        public enum KetQua
        {
            TrungMa,
            ThanhCong
        }
        public static List<SinhVienViewModel> GetList()
        {
            var db = new AppDB();
            #region Cú Pháp liuQ
            var rs = db.SinhViens.Select(e => new SinhVienViewModel
            {
                ID = e.ID,
                IDLopHoc = e.IDLopHoc,
                MaSinhVien = e.MaSinhVien,
                HoDem = e.HoDem,
                Ten = e.Ten,
                NgaySinh = e.NgaySinh,
                GioiTinh = e.GioiTinh,
                QueQuan = e.QueQuan,
            }).ToList();
            #endregion
            return rs;
        }
        public static List<SinhVienViewModel> GetList(int idLopHoc)
        {
            var db = new AppDB();
            #region Cú Pháp liuQ
            var rs = db.SinhViens
                .Where(e => e.IDLopHoc == idLopHoc)
                .Select(e => new SinhVienViewModel
                {
                    ID = e.ID,
                    IDLopHoc = e.IDLopHoc,
                    MaSinhVien = e.MaSinhVien,
                    HoDem = e.HoDem,
                    Ten = e.Ten,
                    NgaySinh = e.NgaySinh,
                    GioiTinh = e.GioiTinh,
                    QueQuan = e.QueQuan,
                }).ToList();
            #endregion
            return rs;
        }
        public static KetQua AddSinhVien(SinhVien sv)
        {
            var db = new AppDB();
            int count = db.SinhViens.Where(e => e.MaSinhVien == sv.MaSinhVien).Count();
            if (count > 0)
            {
                return KetQua.TrungMa;
            }
            else
            {
                db.SinhViens.Add(sv);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
        }
        public static KetQua UpdateSinhVien(SinhVienViewModel sv)
        {
            var db = new AppDB();
            var sinhVien = db.SinhViens.Where(e => e.ID == sv.ID).FirstOrDefault();
            sinhVien.Ten = sv.Ten;
            sinhVien.HoDem = sv.HoDem;
            sinhVien.QueQuan = sv.QueQuan;
            sinhVien.IDLopHoc = sv.IDLopHoc;
            sinhVien.GioiTinh = sv.GioiTinh;
            sinhVien.MaSinhVien = sv.MaSinhVien;
            sinhVien.NgaySinh = sv.NgaySinh;
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
        public static KetQua RemoveSinhVien(SinhVienViewModel sv)
        {
            var db = new AppDB();
            var sinhVien = db.SinhViens.Where(e => e.ID == sv.ID).FirstOrDefault();
            db.SinhViens.Remove(sinhVien);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }
}

