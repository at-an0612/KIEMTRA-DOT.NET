using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTra01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDBDataSet1.DanhSach' table. You can move, or remove it, as needed.
            this.danhSachTableAdapter.Fill(this.qLDBDataSet1.DanhSach);
            // TODO: This line of code loads data into the 'qLDBDataSet.Nhom' table. You can move, or remove it, as needed.
            this.nhomTableAdapter.Fill(this.qLDBDataSet.Nhom);

        }
    }
}
