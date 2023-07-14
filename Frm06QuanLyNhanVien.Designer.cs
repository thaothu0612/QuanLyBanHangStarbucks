namespace QuanLyBanHangStarbucks
{
    partial class Frm06QuanLyNhanVien
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
            this.rdPosition = new System.Windows.Forms.GroupBox();
            this.rdChucVu = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdNameKM = new System.Windows.Forms.RadioButton();
            this.rdCodeNV = new System.Windows.Forms.RadioButton();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.DTPNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblUnitMH = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblCategoryMH = new System.Windows.Forms.Label();
            this.txtNameNV = new System.Windows.Forms.TextBox();
            this.lblNameMH = new System.Windows.Forms.Label();
            this.txtCodeNV = new System.Windows.Forms.TextBox();
            this.lblCodeMH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdPosition.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.BackgroundImage = global::QuanLyBanHangStarbucks.Properties.Resources.house_chimney_window;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(1201, 26);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 60);
            this.btnHome.TabIndex = 27;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // rdPosition
            // 
            this.rdPosition.AutoSize = true;
            this.rdPosition.BackColor = System.Drawing.Color.Transparent;
            this.rdPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdPosition.Controls.Add(this.rdChucVu);
            this.rdPosition.Controls.Add(this.btnTimKiem);
            this.rdPosition.Controls.Add(this.groupBox3);
            this.rdPosition.Controls.Add(this.rdNameKM);
            this.rdPosition.Controls.Add(this.rdCodeNV);
            this.rdPosition.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdPosition.ForeColor = System.Drawing.Color.White;
            this.rdPosition.Location = new System.Drawing.Point(764, 150);
            this.rdPosition.Name = "rdPosition";
            this.rdPosition.Size = new System.Drawing.Size(455, 334);
            this.rdPosition.TabIndex = 26;
            this.rdPosition.TabStop = false;
            this.rdPosition.Text = "Tìm kiếm";
            // 
            // rdChucVu
            // 
            this.rdChucVu.AutoSize = true;
            this.rdChucVu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdChucVu.Location = new System.Drawing.Point(31, 88);
            this.rdChucVu.Name = "rdChucVu";
            this.rdChucVu.Size = new System.Drawing.Size(100, 25);
            this.rdChucVu.TabIndex = 13;
            this.rdChucVu.TabStop = true;
            this.rdChucVu.Text = "Chức vụ";
            this.rdChucVu.UseVisualStyleBackColor = true;
            this.rdChucVu.CheckedChanged += new System.EventHandler(this.rdChucVu_CheckedChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTimKiem.Location = new System.Drawing.Point(31, 267);
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
            this.groupBox3.Location = new System.Drawing.Point(31, 149);
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
            // rdNameKM
            // 
            this.rdNameKM.AutoSize = true;
            this.rdNameKM.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdNameKM.Location = new System.Drawing.Point(251, 39);
            this.rdNameKM.Name = "rdNameKM";
            this.rdNameKM.Size = new System.Drawing.Size(151, 25);
            this.rdNameKM.TabIndex = 1;
            this.rdNameKM.TabStop = true;
            this.rdNameKM.Text = "Tên nhân viên";
            this.rdNameKM.UseVisualStyleBackColor = true;
            this.rdNameKM.CheckedChanged += new System.EventHandler(this.rdNameKM_CheckedChanged);
            // 
            // rdCodeNV
            // 
            this.rdCodeNV.AutoSize = true;
            this.rdCodeNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdCodeNV.Location = new System.Drawing.Point(31, 41);
            this.rdCodeNV.Name = "rdCodeNV";
            this.rdCodeNV.Size = new System.Drawing.Size(145, 25);
            this.rdCodeNV.TabIndex = 0;
            this.rdCodeNV.TabStop = true;
            this.rdCodeNV.Text = "Mã nhân viên";
            this.rdCodeNV.UseVisualStyleBackColor = true;
            this.rdCodeNV.CheckedChanged += new System.EventHandler(this.rdCodeNV_CheckedChanged);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCuoi.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCuoi.Location = new System.Drawing.Point(760, 785);
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
            this.btnSau.Location = new System.Drawing.Point(657, 785);
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
            this.btnTruoc.Location = new System.Drawing.Point(550, 785);
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
            this.btnDau.Location = new System.Drawing.Point(450, 785);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(82, 35);
            this.btnDau.TabIndex = 18;
            this.btnDau.Text = "|<";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(57, 513);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 29;
            this.dgvNhanVien.Size = new System.Drawing.Size(1162, 249);
            this.dgvNhanVien.TabIndex = 25;
            this.dgvNhanVien.SelectionChanged += new System.EventHandler(this.dgvNhanVien_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.DTPNgaySinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblUnitMH);
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.lblCategoryMH);
            this.groupBox1.Controls.Add(this.txtNameNV);
            this.groupBox1.Controls.Add(this.lblNameMH);
            this.groupBox1.Controls.Add(this.txtCodeNV);
            this.groupBox1.Controls.Add(this.lblCodeMH);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(57, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 333);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPosition.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPosition.Location = new System.Drawing.Point(495, 201);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(165, 28);
            this.txtPosition.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(368, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Chức vụ:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPhoneNumber.Location = new System.Drawing.Point(495, 90);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(165, 28);
            this.txtPhoneNumber.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(368, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Điện thoại:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtEmail.Location = new System.Drawing.Point(495, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 28);
            this.txtEmail.TabIndex = 16;
            // 
            // DTPNgaySinh
            // 
            this.DTPNgaySinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTPNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPNgaySinh.Location = new System.Drawing.Point(185, 201);
            this.DTPNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTPNgaySinh.Name = "DTPNgaySinh";
            this.DTPNgaySinh.Size = new System.Drawing.Size(165, 27);
            this.DTPNgaySinh.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(368, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày sinh:";
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
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAddress.Location = new System.Drawing.Point(495, 36);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(165, 28);
            this.txtAddress.TabIndex = 7;
            // 
            // lblUnitMH
            // 
            this.lblUnitMH.AutoSize = true;
            this.lblUnitMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnitMH.Location = new System.Drawing.Point(22, 153);
            this.lblUnitMH.Name = "lblUnitMH";
            this.lblUnitMH.Size = new System.Drawing.Size(83, 21);
            this.lblUnitMH.TabIndex = 6;
            this.lblUnitMH.Text = "Giới tính";
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSex.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSex.Location = new System.Drawing.Point(185, 147);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(165, 28);
            this.txtSex.TabIndex = 5;
            // 
            // lblCategoryMH
            // 
            this.lblCategoryMH.AutoSize = true;
            this.lblCategoryMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryMH.Location = new System.Drawing.Point(368, 43);
            this.lblCategoryMH.Name = "lblCategoryMH";
            this.lblCategoryMH.Size = new System.Drawing.Size(74, 21);
            this.lblCategoryMH.TabIndex = 4;
            this.lblCategoryMH.Text = "Địa chỉ:";
            // 
            // txtNameNV
            // 
            this.txtNameNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameNV.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtNameNV.Location = new System.Drawing.Point(185, 91);
            this.txtNameNV.Name = "txtNameNV";
            this.txtNameNV.Size = new System.Drawing.Size(165, 28);
            this.txtNameNV.TabIndex = 3;
            // 
            // lblNameMH
            // 
            this.lblNameMH.AutoSize = true;
            this.lblNameMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameMH.Location = new System.Drawing.Point(22, 96);
            this.lblNameMH.Name = "lblNameMH";
            this.lblNameMH.Size = new System.Drawing.Size(136, 21);
            this.lblNameMH.TabIndex = 2;
            this.lblNameMH.Text = "Tên nhân viên:";
            // 
            // txtCodeNV
            // 
            this.txtCodeNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodeNV.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtCodeNV.Location = new System.Drawing.Point(185, 36);
            this.txtCodeNV.Name = "txtCodeNV";
            this.txtCodeNV.Size = new System.Drawing.Size(165, 28);
            this.txtCodeNV.TabIndex = 1;
            // 
            // lblCodeMH
            // 
            this.lblCodeMH.AutoSize = true;
            this.lblCodeMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodeMH.Location = new System.Drawing.Point(22, 43);
            this.lblCodeMH.Name = "lblCodeMH";
            this.lblCodeMH.Size = new System.Drawing.Size(130, 21);
            this.lblCodeMH.TabIndex = 0;
            this.lblCodeMH.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(502, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // Frm06QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHangStarbucks.Properties.Resources.bg9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1295, 856);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.rdPosition);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnDau);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm06QuanLyNhanVien";
            this.Text = "Frm06QuanLyNhanVien";
            this.Load += new System.EventHandler(this.Frm06QuanLyNhanVien_Load);
            this.rdPosition.ResumeLayout(false);
            this.rdPosition.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHome;
        private GroupBox rdPosition;
        private Button btnTimKiem;
        private GroupBox groupBox3;
        private TextBox txtTimKiem;
        private Button btnCuoi;
        private RadioButton rdNameKM;
        private Button btnSau;
        private RadioButton rdCodeNV;
        private Button btnTruoc;
        private Button btnDau;
        private DataGridView dgvNhanVien;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private DateTimePicker DTPNgaySinh;
        private Label label4;
        private Label label2;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtAddress;
        private Label lblUnitMH;
        private TextBox txtSex;
        private Label lblCategoryMH;
        private TextBox txtNameNV;
        private Label lblNameMH;
        private TextBox txtCodeNV;
        private Label lblCodeMH;
        private Label label1;
        private TextBox txtPosition;
        private Label label3;
        private TextBox txtPhoneNumber;
        private Label label5;
        private RadioButton rdChucVu;
    }
}