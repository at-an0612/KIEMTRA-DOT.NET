using WindowsFormsApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ViewModel
{
    internal class LopHocViewModel
    {
        public int ID { get; set; }
        public string Tenlop { get; set; }

        public static List<LopHocViewModel> GetList()
        {
            var db = new appDBQLSV();
            #region Cú Pháp liuQ
            var rs = db.LopHocs.Select(e => new LopHocViewModel
            {
                ID = e.ID,
                Tenlop = e.TenLop
            }).ToList();
            #endregion
            return rs;
        }
       
    }
}

