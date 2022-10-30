using Buoi3.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDsKhoa();
           
        }
        void NapDsKhoa()
        {
            var ds = KhoaViewModel.getList();
            cbbKhoa.DataSource = ds;
            cbbKhoa.DisplayMember = "TenKhoa"; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void NapDSGiangVien()
        {
            if(selectedKhoa !=null)
            {
                var list = GiangVienViewModel.getByKhoa(selectedKhoa.MaKhoa);
                bdsGiangVien.DataSource = list; 
                gridGiangVien.DataSource = bdsGiangVien;
            }
        }
        public KhoaViewModel selectedKhoa
        {
            get
            {
                return cbbKhoa.SelectedItem as KhoaViewModel; 
            }
        }
        public GiangVienViewModel selectedGiangVien
        {
            get
            {
                return bdsGiangVien.Current as GiangVienViewModel;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectedKhoa !=null)
            {
               
                NapDSGiangVien();

            }


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThongTinGiangVien_Click(object sender, EventArgs e)
        {
          if(selectedGiangVien !=null)
            {
                MessageBox.Show($"Xin Chào {(selectedGiangVien.GioiTinh ? "Thầy" : "Cô")} {selectedGiangVien.HoVaTen}");
                frmGiangVien formGiangVien = new frmGiangVien(); 
                formGiangVien.ShowDialog(); 
            }
          
        }
    }
}
