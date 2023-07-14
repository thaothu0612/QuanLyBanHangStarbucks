namespace QuanLyBanHangStarbucks
{
    partial class Frm07QuanLyKhachHang
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
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.rdPhoneNumber = new System.Windows.Forms.RadioButton();
            this.btnSau = new System.Windows.Forms.Button();
            this.rdCodeKH = new System.Windows.Forms.RadioButton();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblUnitMH = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblCategoryMH = new System.Windows.Forms.Label();
            this.txtNameKH = new System.Windows.Forms.TextBox();
            this.lblNameMH = new System.Windows.Forms.Label();
            this.txtCodeKH = new System.Windows.Forms.TextBox();
            this.lblCodeMH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.BackgroundImage = global::QuanLyBanHangStarbucks.Properties.Resources.house_chimney_window;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(1196, 36);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 60);
            this.btnHome.TabIndex = 28;
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
            this.groupBox2.Controls.Add(this.rdPhoneNumber);
            this.groupBox2.Controls.Add(this.btnSau);
            this.groupBox2.Controls.Add(this.rdCodeKH);
            this.groupBox2.Controls.Add(this.btnTruoc);
            this.groupBox2.Controls.Add(this.btnDau);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(770, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 335);
            this.groupBox2.TabIndex = 27;
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
            this.txtTimKiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtTimKiem.Location = new System.Drawing.Point(29, 39);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(329, 28);
            this.txtTimKiem.TabIndex = 12;
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
            // rdPhoneNumber
            // 
            this.rdPhoneNumber.AutoSize = true;
            this.rdPhoneNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdPhoneNumber.Location = new System.Drawing.Point(251, 39);
            this.rdPhoneNumber.Name = "rdPhoneNumber";
            this.rdPhoneNumber.Size = new System.Drawing.Size(119, 25);
            this.rdPhoneNumber.TabIndex = 1;
            this.rdPhoneNumber.TabStop = true;
            this.rdPhoneNumber.Text = "Điện thoại";
            this.rdPhoneNumber.UseVisualStyleBackColor = true;
            this.rdPhoneNumber.CheckedChanged += new System.EventHandler(this.rdPhoneNumber_CheckedChanged);
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
            // rdCodeKH
            // 
            this.rdCodeKH.AutoSize = true;
            this.rdCodeKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdCodeKH.Location = new System.Drawing.Point(31, 41);
            this.rdCodeKH.Name = "rdCodeKH";
            this.rdCodeKH.Size = new System.Drawing.Size(160, 25);
            this.rdCodeKH.TabIndex = 0;
            this.rdCodeKH.TabStop = true;
            this.rdCodeKH.Text = "Mã khách hàng";
            this.rdCodeKH.UseVisualStyleBackColor = true;
            this.rdCodeKH.CheckedChanged += new System.EventHandler(this.rdCodeKH_CheckedChanged);
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
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(63, 510);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 29;
            this.dgvKhachHang.Size = new System.Drawing.Size(1163, 282);
            this.dgvKhachHang.TabIndex = 26;
            this.dgvKhachHang.SelectionChanged += new System.EventHandler(this.dgvKhachHang_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.lblUnitMH);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.lblCategoryMH);
            this.groupBox1.Controls.Add(this.txtNameKH);
            this.groupBox1.Controls.Add(this.lblNameMH);
            this.groupBox1.Controls.Add(this.txtCodeKH);
            this.groupBox1.Controls.Add(this.lblCodeMH);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(63, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 335);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAddress.Location = new System.Drawing.Point(185, 145);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(475, 28);
            this.txtAddress.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Địa chỉ:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtEmail.Location = new System.Drawing.Point(495, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 28);
            this.txtEmail.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(368, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email:";
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
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSex.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSex.Location = new System.Drawing.Point(495, 36);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(165, 28);
            this.txtSex.TabIndex = 7;
            // 
            // lblUnitMH
            // 
            this.lblUnitMH.AutoSize = true;
            this.lblUnitMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnitMH.Location = new System.Drawing.Point(22, 206);
            this.lblUnitMH.Name = "lblUnitMH";
            this.lblUnitMH.Size = new System.Drawing.Size(104, 21);
            this.lblUnitMH.TabIndex = 6;
            this.lblUnitMH.Text = "Điện thoại:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPhoneNumber.Location = new System.Drawing.Point(185, 200);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(165, 28);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // lblCategoryMH
            // 
            this.lblCategoryMH.AutoSize = true;
            this.lblCategoryMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryMH.Location = new System.Drawing.Point(368, 43);
            this.lblCategoryMH.Name = "lblCategoryMH";
            this.lblCategoryMH.Size = new System.Drawing.Size(89, 21);
            this.lblCategoryMH.TabIndex = 4;
            this.lblCategoryMH.Text = "Giới tính:";
            // 
            // txtNameKH
            // 
            this.txtNameKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameKH.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtNameKH.Location = new System.Drawing.Point(185, 91);
            this.txtNameKH.Name = "txtNameKH";
            this.txtNameKH.Size = new System.Drawing.Size(475, 28);
            this.txtNameKH.TabIndex = 3;
            // 
            // lblNameMH
            // 
            this.lblNameMH.AutoSize = true;
            this.lblNameMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameMH.Location = new System.Drawing.Point(22, 96);
            this.lblNameMH.Name = "lblNameMH";
            this.lblNameMH.Size = new System.Drawing.Size(151, 21);
            this.lblNameMH.TabIndex = 2;
            this.lblNameMH.Text = "Tên khách hàng:";
            // 
            // txtCodeKH
            // 
            this.txtCodeKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodeKH.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtCodeKH.Location = new System.Drawing.Point(185, 36);
            this.txtCodeKH.Name = "txtCodeKH";
            this.txtCodeKH.Size = new System.Drawing.Size(165, 28);
            this.txtCodeKH.TabIndex = 1;
            // 
            // lblCodeMH
            // 
            this.lblCodeMH.AutoSize = true;
            this.lblCodeMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodeMH.Location = new System.Drawing.Point(22, 43);
            this.lblCodeMH.Name = "lblCodeMH";
            this.lblCodeMH.Size = new System.Drawing.Size(145, 21);
            this.lblCodeMH.TabIndex = 0;
            this.lblCodeMH.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(468, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 40);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quản lý khách hàng";
            // 
            // Frm07QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHangStarbucks.Properties.Resources.bg9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1295, 856);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm07QuanLyKhachHang";
            this.Text = "Frm07QuanLyKhachHang";
            this.Load += new System.EventHandler(this.Frm07QuanLyKhachHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHome;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private GroupBox groupBox3;
        private TextBox txtTimKiem;
        private Button btnCuoi;
        private RadioButton rdPhoneNumber;
        private Button btnSau;
        private RadioButton rdCodeKH;
        private Button btnTruoc;
        private Button btnDau;
        private DataGridView dgvKhachHang;
        private GroupBox groupBox1;
        private TextBox txtAddress;
        private Label label2;
        private TextBox txtEmail;
        private Label label4;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtSex;
        private Label lblUnitMH;
        private TextBox txtPhoneNumber;
        private Label lblCategoryMH;
        private TextBox txtNameKH;
        private Label lblNameMH;
        private TextBox txtCodeKH;
        private Label lblCodeMH;
        private Label label1;
    }
}