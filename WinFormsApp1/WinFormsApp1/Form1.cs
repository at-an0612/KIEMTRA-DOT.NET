using buoi3;

namespace buoi3

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

        void NapDsGiangVien()
        {
            if (selectenkhoa != null)
            {
                var list = GiangVien.getByKhoa(selectsdKhoa.MaKhoa);
                GridGiangVien.DataSource = list;
            }
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapDsGiangVien();
        }

        private ComboBox cbbKhoa;
        private Label label1;
        private DataGridView GridGiangVien;
        private Label label2;
        private Button button1;

        public khoaViewModel selectenkhoa
        {
            get cbbKhoa.SelectedItem as KhoaViewModel;
        }

        private void InitializeComponent()
        {
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridGiangVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(115, 49);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(169, 33);
            this.cbbKhoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "khoa";
            // 
            // GridGiangVien
            // 
            this.GridGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGiangVien.Location = new System.Drawing.Point(44, 137);
            this.GridGiangVien.Name = "GridGiangVien";
            this.GridGiangVien.RowHeadersWidth = 62;
            this.GridGiangVien.RowTemplate.Height = 33;
            this.GridGiangVien.Size = new System.Drawing.Size(706, 278);
            this.GridGiangVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "danh sach giang vien";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridGiangVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbKhoa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
    }
}