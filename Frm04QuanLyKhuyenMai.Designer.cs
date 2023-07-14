namespace QuanLyBanHangStarbucks
{
    partial class Frm04QuanLyKhuyenMai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIsActive = new System.Windows.Forms.RadioButton();
            this.DTPEndDay = new System.Windows.Forms.DateTimePicker();
            this.txtHinhThuc = new System.Windows.Forms.TextBox();
            this.DTPStartDay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblUnitMH = new System.Windows.Forms.Label();
            this.txtDieuKien = new System.Windows.Forms.TextBox();
            this.lblCategoryMH = new System.Windows.Forms.Label();
            this.txtNameKM = new System.Windows.Forms.TextBox();
            this.lblNameMH = new System.Windows.Forms.Label();
            this.txtCodeKM = new System.Windows.Forms.TextBox();
            this.lblCodeMH = new System.Windows.Forms.Label();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdNameKM = new System.Windows.Forms.RadioButton();
            this.rdCodeKM = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(459, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý khuyến mãi";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rbIsActive);
            this.groupBox1.Controls.Add(this.DTPEndDay);
            this.groupBox1.Controls.Add(this.txtHinhThuc);
            this.groupBox1.Controls.Add(this.DTPStartDay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtProductId);
            this.groupBox1.Controls.Add(this.lblUnitMH);
            this.groupBox1.Controls.Add(this.txtDieuKien);
            this.groupBox1.Controls.Add(this.lblCategoryMH);
            this.groupBox1.Controls.Add(this.txtNameKM);
            this.groupBox1.Controls.Add(this.lblNameMH);
            this.groupBox1.Controls.Add(this.txtCodeKM);
            this.groupBox1.Controls.Add(this.lblCodeMH);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(51, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 335);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khuyến mãi";
            // 
            // rbIsActive
            // 
            this.rbIsActive.AutoSize = true;
            this.rbIsActive.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbIsActive.Location = new System.Drawing.Point(541, 98);
            this.rbIsActive.Name = "rbIsActive";
            this.rbIsActive.Size = new System.Drawing.Size(119, 25);
            this.rbIsActive.TabIndex = 18;
            this.rbIsActive.TabStop = true;
            this.rbIsActive.Text = "Tình trạng";
            this.rbIsActive.UseVisualStyleBackColor = true;
            // 
            // DTPEndDay
            // 
            this.DTPEndDay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTPEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPEndDay.Location = new System.Drawing.Point(495, 201);
            this.DTPEndDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTPEndDay.Name = "DTPEndDay";
            this.DTPEndDay.Size = new System.Drawing.Size(165, 27);
            this.DTPEndDay.TabIndex = 17;
            // 
            // txtHinhThuc
            // 
            this.txtHinhThuc.Location = new System.Drawing.Point(495, 147);
            this.txtHinhThuc.Name = "txtHinhThuc";
            this.txtHinhThuc.Size = new System.Drawing.Size(165, 32);
            this.txtHinhThuc.TabIndex = 16;
            // 
            // DTPStartDay
            // 
            this.DTPStartDay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTPStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPStartDay.Location = new System.Drawing.Point(185, 201);
            this.DTPStartDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTPStartDay.Name = "DTPStartDay";
            this.DTPStartDay.Size = new System.Drawing.Size(165, 27);
            this.DTPStartDay.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(368, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hình thức:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(368, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLamMoi.Location = new System.Drawing.Point(538, 267);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(122, 35);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Reset";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSua.Location = new System.Drawing.Point(368, 267);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 35);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnXoa.Location = new System.Drawing.Point(195, 267);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 35);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnThem.Location = new System.Drawing.Point(22, 267);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 35);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(495, 36);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(165, 32);
            this.txtProductId.TabIndex = 7;
            // 
            // lblUnitMH
            // 
            this.lblUnitMH.AutoSize = true;
            this.lblUnitMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnitMH.Location = new System.Drawing.Point(22, 153);
            this.lblUnitMH.Name = "lblUnitMH";
            this.lblUnitMH.Size = new System.Drawing.Size(96, 21);
            this.lblUnitMH.TabIndex = 6;
            this.lblUnitMH.Text = "Điều kiện:";
            // 
            // txtDieuKien
            // 
            this.txtDieuKien.Location = new System.Drawing.Point(185, 147);
            this.txtDieuKien.Name = "txtDieuKien";
            this.txtDieuKien.Size = new System.Drawing.Size(165, 32);
            this.txtDieuKien.TabIndex = 5;
            // 
            // lblCategoryMH
            // 
            this.lblCategoryMH.AutoSize = true;
            this.lblCategoryMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryMH.Location = new System.Drawing.Point(360, 43);
            this.lblCategoryMH.Name = "lblCategoryMH";
            this.lblCategoryMH.Size = new System.Drawing.Size(127, 21);
            this.lblCategoryMH.TabIndex = 4;
            this.lblCategoryMH.Text = "Mã mặt hàng:";
            // 
            // txtNameKM
            // 
            this.txtNameKM.Location = new System.Drawing.Point(185, 91);
            this.txtNameKM.Name = "txtNameKM";
            this.txtNameKM.Size = new System.Drawing.Size(309, 32);
            this.txtNameKM.TabIndex = 3;
            // 
            // lblNameMH
            // 
            this.lblNameMH.AutoSize = true;
            this.lblNameMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameMH.Location = new System.Drawing.Point(22, 96);
            this.lblNameMH.Name = "lblNameMH";
            this.lblNameMH.Size = new System.Drawing.Size(151, 21);
            this.lblNameMH.TabIndex = 2;
            this.lblNameMH.Text = "Tên khuyến mãi:";
            // 
            // txtCodeKM
            // 
            this.txtCodeKM.Location = new System.Drawing.Point(185, 36);
            this.txtCodeKM.Name = "txtCodeKM";
            this.txtCodeKM.Size = new System.Drawing.Size(165, 32);
            this.txtCodeKM.TabIndex = 1;
            // 
            // lblCodeMH
            // 
            this.lblCodeMH.AutoSize = true;
            this.lblCodeMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodeMH.Location = new System.Drawing.Point(22, 43);
            this.lblCodeMH.Name = "lblCodeMH";
            this.lblCodeMH.Size = new System.Drawing.Size(145, 21);
            this.lblCodeMH.TabIndex = 0;
            this.lblCodeMH.Text = "Mã khuyến mãi:";
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCuoi.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCuoi.Location = new System.Drawing.Point(341, 268);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(82, 35);
            this.btnCuoi.TabIndex = 21;
            this.btnCuoi.Text = ">|";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSau.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSau.Location = new System.Drawing.Point(238, 268);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(82, 35);
            this.btnSau.TabIndex = 20;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTruoc.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTruoc.Location = new System.Drawing.Point(131, 268);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(82, 35);
            this.btnTruoc.TabIndex = 19;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnDau
            // 
            this.btnDau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDau.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDau.Location = new System.Drawing.Point(31, 268);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(82, 35);
            this.btnDau.TabIndex = 18;
            this.btnDau.Text = "|<";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuyenMai.Location = new System.Drawing.Point(51, 492);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.RowHeadersWidth = 51;
            this.dgvKhuyenMai.RowTemplate.Height = 29;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(1162, 252);
            this.dgvKhuyenMai.TabIndex = 17;
            this.dgvKhuyenMai.SelectionChanged += new System.EventHandler(this.dgvKhuyenMai_SelectionChanged);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.BackgroundImage = global::QuanLyBanHangStarbucks.Properties.Resources.house_chimney_window;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(1172, 17);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 60);
            this.btnHome.TabIndex = 23;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnCuoi);
            this.groupBox2.Controls.Add(this.rdNameKM);
            this.groupBox2.Controls.Add(this.btnSau);
            this.groupBox2.Controls.Add(this.rdCodeKM);
            this.groupBox2.Controls.Add(this.btnTruoc);
            this.groupBox2.Controls.Add(this.btnDau);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(758, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 335);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTimKiem.Location = new System.Drawing.Point(31, 209);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(392, 35);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(31, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(29, 39);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(329, 28);
            this.txtTimKiem.TabIndex = 12;
            // 
            // rdNameKM
            // 
            this.rdNameKM.AutoSize = true;
            this.rdNameKM.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdNameKM.Location = new System.Drawing.Point(251, 39);
            this.rdNameKM.Name = "rdNameKM";
            this.rdNameKM.Size = new System.Drawing.Size(166, 25);
            this.rdNameKM.TabIndex = 1;
            this.rdNameKM.TabStop = true;
            this.rdNameKM.Text = "Tên khuyến mãi";
            this.rdNameKM.UseVisualStyleBackColor = true;
            this.rdNameKM.CheckedChanged += new System.EventHandler(this.rdNameKM_CheckedChanged);
            // 
            // rdCodeKM
            // 
            this.rdCodeKM.AutoSize = true;
            this.rdCodeKM.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdCodeKM.Location = new System.Drawing.Point(31, 41);
            this.rdCodeKM.Name = "rdCodeKM";
            this.rdCodeKM.Size = new System.Drawing.Size(160, 25);
            this.rdCodeKM.TabIndex = 0;
            this.rdCodeKM.TabStop = true;
            this.rdCodeKM.Text = "Mã khuyến mãi";
            this.rdCodeKM.UseVisualStyleBackColor = true;
            this.rdCodeKM.CheckedChanged += new System.EventHandler(this.rdCodeKM_CheckedChanged);
            // 
            // Frm04QuanLyKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHangStarbucks.Properties.Resources.bg9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 797);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvKhuyenMai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm04QuanLyKhuyenMai";
            this.Text = "Frm04QuanLyKhuyenMai";
            this.Load += new System.EventHandler(this.Frm04QuanLyKhuyenMai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtProductId;
        private Label lblUnitMH;
        private TextBox txtDieuKien;
        private Label lblCategoryMH;
        private TextBox txtNameKM;
        private Label lblNameMH;
        private TextBox txtCodeKM;
        private Label lblCodeMH;
        private Button btnCuoi;
        private Button btnSau;
        private Button btnTruoc;
        private Button btnDau;
        private DataGridView dgvKhuyenMai;
        private Button btnHome;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private GroupBox groupBox3;
        private TextBox txtTimKiem;
        private RadioButton rdNameKM;
        private RadioButton rdCodeKM;
        private DateTimePicker DTPEndDay;
        private TextBox txtHinhThuc;
        private DateTimePicker DTPStartDay;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton rbIsActive;
    }
}