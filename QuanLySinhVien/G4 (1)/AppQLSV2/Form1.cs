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

namespace AppQLSV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDsLopHoc();
            NapDsSinhVien();
        }
        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return cbbLopHoc.SelectedItem as 
                LopHocViewModel;
               
            }
        }
        public SinhVienViewModel selectedSinhVien
        {
            get
            {
                return sinhVienViewModelBindingSource.Current as SinhVienViewModel; 
            }
        }
        void NapDsLopHoc()
        {
            var ls = LopHocViewModel.GetList();
            cbbLopHoc.DataSource = ls;
            cbbLopHoc.DisplayMember = "TenLop";
        }
        void NapDsSinhVien()
        {
            if(selectedLopHoc != null) 
            {
                var ls = SinhVienService.GetList(selectedLopHoc.ID);
                sinhVienViewModelBindingSource.DataSource = ls;
                dataGridView1.DataSource = sinhVienViewModelBindingSource;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapDsSinhVien();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Gv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm Tra ma sinh vien có trung hay khong
            //MSV, ho , ten, khong duoc de trong
            var f = new frmSinhVien();
            var rs = f.ShowDialog();
            if(rs == DialogResult.OK)
            {
                NapDsSinhVien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(selectedSinhVien != null)
            {
                var f = new frmSinhVien(selectedSinhVien);
                if (f.ShowDialog() == DialogResult.OK)
                    NapDsSinhVien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(selectedSinhVien != null)
            {
                var rs = MessageBox.Show("Bạn có chắc muốn xóa?", "CHú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(rs == DialogResult.OK)
                {
                    SinhVienService.RemoveSinhVien(selectedSinhVien);
                    NapDsSinhVien();
                }

            }
        }
    }
}
