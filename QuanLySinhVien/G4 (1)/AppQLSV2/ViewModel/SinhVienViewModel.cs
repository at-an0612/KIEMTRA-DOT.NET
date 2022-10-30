﻿using AppQLSV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AppQLSV2.ViewModel
{
    public class SinhVienViewModel
    {
        public int ID { get; set; }


        public string MaSinhVien { get; set; }


        public string HoDem { get; set; }


        public string Ten { get; set; }


        public DateTime? NgaySinh { get; set; }

        public int? GioiTinh { get; set; }

        public string QueQuan { get; set; }

        public int? IDLopHoc { get; set; }
    }
}
       


