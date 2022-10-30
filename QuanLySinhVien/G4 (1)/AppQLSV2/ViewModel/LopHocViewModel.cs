using AppQLSV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppQLSV2.ViewModel
{
    public class LopHocViewModel
    {
        public int ID { get; set; } 
        public string Tenlop { get; set; }
        public static List<LopHocViewModel> GetList()
        {
            var db = new AppDB();
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
