namespace QuanLyBanHangStarbucks
{
    partial class Frm05QuanLyTaiKhoan
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
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdNameMH = new System.Windows.Forms.RadioButton();
            this.rdCodeMH = new System.Windows.Forms.RadioButton();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.lblUnitMH = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.lblCategoryMH = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblNameMH = new System.Windows.Forms.Label();
            this.txtCodeTK = new System.Windows.Forms.TextBox();
            this.lblCodeMH = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(507, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCuoi.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCuoi.Location = new System.Drawing.Point(842, 765);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(121, 35);
            this.btnCuoi.TabIndex = 23;
            this.btnCuoi.Text = ">|";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSau.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSau.Location = new System.Drawing.Point(674, 765);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(121, 35);
            this.btnSau.TabIndex = 22;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTruoc.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTruoc.Location = new System.Drawing.Point(502, 765);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(121, 35);
            this.btnTruoc.TabIndex = 21;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnDau
            // 
            this.btnDau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDau.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDau.Location = new System.Drawing.Point(334, 765);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(121, 35);
            this.btnDau.TabIndex = 20;
            this.btnDau.Text = "|<";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.rdNameMH);
            this.groupBox2.Controls.Add(this.rdCodeMH);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(768, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 276);
            this.groupBox2.TabIndex = 19;
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
            this.txtTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(29, 39);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(329, 35);
            this.txtTimKiem.TabIndex = 12;
            // 
            // rdNameMH
            // 
            this.rdNameMH.AutoSize = true;
            this.rdNameMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdNameMH.Location = new System.Drawing.Point(251, 39);
            this.rdNameMH.Name = "rdNameMH";
            this.rdNameMH.Size = new System.Drawing.Size(139, 25);
            this.rdNameMH.TabIndex = 1;
            this.rdNameMH.TabStop = true;
            this.rdNameMH.Text = "Id nhân viên";
            this.rdNameMH.UseVisualStyleBackColor = true;
            this.rdNameMH.CheckedChanged += new System.EventHandler(this.rdNameMH_CheckedChanged);
            // 
            // rdCodeMH
            // 
            this.rdCodeMH.AutoSize = true;
            this.rdCodeMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdCodeMH.Location = new System.Drawing.Point(31, 41);
            this.rdCodeMH.Name = "rdCodeMH";
            this.rdCodeMH.Size = new System.Drawing.Size(141, 25);
            this.rdCodeMH.TabIndex = 0;
            this.rdCodeMH.TabStop = true;
            this.rdCodeMH.Text = "Mã tài khoản";
            this.rdCodeMH.UseVisualStyleBackColor = true;
            this.rdCodeMH.CheckedChanged += new System.EventHandler(this.rdCodeMH_CheckedChanged);
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(62, 464);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 29;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(1162, 277);
            this.dgvTaiKhoan.TabIndex = 18;
            this.dgvTaiKhoan.SelectionChanged += new System.EventHandler(this.dgvTaiKhoan_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.lblUnitMH);
            this.groupBox1.Controls.Add(this.txtStaffId);
            this.groupBox1.Controls.Add(this.lblCategoryMH);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblNameMH);
            this.groupBox1.Controls.Add(this.txtCodeTK);
            this.groupBox1.Controls.Add(this.lblCodeMH);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(62, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 275);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLamMoi.Location = new System.Drawing.Point(523, 203);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(142, 35);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Reset";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSua.Location = new System.Drawing.Point(523, 147);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 35);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnXoa.Location = new System.Drawing.Point(523, 91);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(142, 35);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnThem.Location = new System.Drawing.Point(523, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 35);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtChucVu.Location = new System.Drawing.Point(195, 149);
            this.txtChucVu.Multiline = true;
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(297, 35);
            this.txtChucVu.TabIndex = 7;
            // 
            // lblUnitMH
            // 
            this.lblUnitMH.AutoSize = true;
            this.lblUnitMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnitMH.Location = new System.Drawing.Point(39, 208);
            this.lblUnitMH.Name = "lblUnitMH";
            this.lblUnitMH.Size = new System.Drawing.Size(124, 21);
            this.lblUnitMH.TabIndex = 6;
            this.lblUnitMH.Text = "Id nhân viên:";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStaffId.Location = new System.Drawing.Point(195, 203);
            this.txtStaffId.Multiline = true;
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(297, 35);
            this.txtStaffId.TabIndex = 5;
            // 
            // lblCategoryMH
            // 
            this.lblCategoryMH.AutoSize = true;
            this.lblCategoryMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryMH.Location = new System.Drawing.Point(39, 152);
            this.lblCategoryMH.Name = "lblCategoryMH";
            this.lblCategoryMH.Size = new System.Drawing.Size(85, 21);
            this.lblCategoryMH.TabIndex = 4;
            this.lblCategoryMH.Text = "Chức vụ:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(195, 91);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(297, 35);
            this.txtPassword.TabIndex = 3;
            // 
            // lblNameMH
            // 
            this.lblNameMH.AutoSize = true;
            this.lblNameMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameMH.Location = new System.Drawing.Point(39, 95);
            this.lblNameMH.Name = "lblNameMH";
            this.lblNameMH.Size = new System.Drawing.Size(95, 21);
            this.lblNameMH.TabIndex = 2;
            this.lblNameMH.Text = "Mật khẩu:";
            // 
            // txtCodeTK
            // 
            this.txtCodeTK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodeTK.Location = new System.Drawing.Point(195, 36);
            this.txtCodeTK.Multiline = true;
            this.txtCodeTK.Name = "txtCodeTK";
            this.txtCodeTK.Size = new System.Drawing.Size(297, 35);
            this.txtCodeTK.TabIndex = 1;
            // 
            // lblCodeMH
            // 
            this.lblCodeMH.AutoSize = true;
            this.lblCodeMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodeMH.Location = new System.Drawing.Point(39, 41);
            this.lblCodeMH.Name = "lblCodeMH";
            this.lblCodeMH.Size = new System.Drawing.Size(126, 21);
            this.lblCodeMH.TabIndex = 0;
            this.lblCodeMH.Text = "Mã tài khoản:";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.BackgroundImage = global::QuanLyBanHangStarbucks.Properties.Resources.house_chimney_window;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(1197, 17);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 60);
            this.btnHome.TabIndex = 24;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Frm05QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHangStarbucks.Properties.Resources.bg9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1295, 856);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm05QuanLyTaiKhoan";
            this.Text = "Frm05QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.Frm05QuanLyTaiKhoan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnCuoi;
        private Button btnSau;
        private Button btnTruoc;
        private Button btnDau;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private GroupBox groupBox3;
        private TextBox txtTimKiem;
        private RadioButton rdNameMH;
        private RadioButton rdCodeMH;
        private DataGridView dgvTaiKhoan;
        private GroupBox groupBox1;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtChucVu;
        private Label lblUnitMH;
        private TextBox txtStaffId;
        private Label lblCategoryMH;
        private TextBox txtPassword;
        private Label lblNameMH;
        private TextBox txtCodeTK;
        private Label lblCodeMH;
        private Button btnHome;
    }
}