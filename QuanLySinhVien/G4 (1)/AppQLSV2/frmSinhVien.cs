using AppQLSV2.Model;
using AppQLSV2.Services;
using AppQLSV2.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace AppQLSV2
{
    public partial class frmSinhVien : Form
    {
        SinhVienViewModel sinhVien;
        public frmSinhVien(SinhVienViewModel sinhVien = null)
        {
            InitializeComponent();
            NapDsLopHoc();
            this.sinhVien = sinhVien;
            if(sinhVien != null)
            {
                cbmLop.SelectedValue = sinhVien.IDLopHoc;
                txtMaSinhVien.Text =   sinhVien.MaSinhVien;
                txtHoDem.Text = sinhVien.HoDem;
                txtTen.Text = sinhVien.Ten;
                dtpNgaySinh.Value = sinhVien.NgaySinh ?? DateTime.Now;
                if(sinhVien.GioiTinh == 0)
                    rdbNam.Checked = true;
                else if(sinhVien.GioiTinh == 1)
                    rdbNu.Checked = true;
                else 
                    rdbKhac.Checked = true; 
                txtQueQuan.Text = sinhVien.QueQuan; 
            }

        }
        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return cbmLop.SelectedItem as LopHocViewModel;
            }
        }
        void NapDsLopHoc()
        {
            var ls = LopHocViewModel.GetList();
            cbmLop.DataSource = ls;
            cbmLop.ValueMember = "ID";
            cbmLop.DisplayMember = "TenLop";
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {

   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if(this.sinhVien == null)
            {
                //Themm mới sinh viên 
            var sv = new SinhVien
            {
                HoDem = txtHoDem.Text,
                Ten = txtTen.Text,
                QueQuan = txtQueQuan.Text,
                NgaySinh = dtpNgaySinh.Value,
                MaSinhVien = txtMaSinhVien.Text,
                IDLopHoc = selectedLopHoc.ID,
                GioiTinh = (rdbNam.Checked ? 0 : rdbNu.Checked ? 1 : 2),
            };
            if (SinhVienService.AddSinhVien(sv) == SinhVienService.KetQua.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("MSV Trùng", "Thông báo");
                txtMaSinhVien.Focus();
            }
            }
            else
                {
                    sinhVien.QueQuan = txtQueQuan.Text;
                sinhVien.NgaySinh = dtpNgaySinh.Value;
                sinhVien.HoDem = txtHoDem.Text;
                sinhVien.Ten = txtTen.Text;
                sinhVien.GioiTinh = (rdbNam.Checked ? 0 : rdbNu.Checked ? 1 : 2);
                sinhVien.IDLopHoc = selectedLopHoc.ID;
                SinhVienService.UpdateSinhVien(sinhVien);
                DialogResult = DialogResult.OK; 
                }
                
        }

        private void cbmLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
