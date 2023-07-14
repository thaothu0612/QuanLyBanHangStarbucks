namespace QuanLyBanHangStarbucks
{
    partial class Frm09ChiTietHoaDon
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
            this.btnTruoc = new System.Windows.Forms.Button();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.rdProductId = new System.Windows.Forms.RadioButton();
            this.btnSau = new System.Windows.Forms.Button();
            this.rdBillId = new System.Windows.Forms.RadioButton();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblUnitMH = new System.Windows.Forms.Label();
            this.txtPriceId = new System.Windows.Forms.TextBox();
            this.lblCategoryMH = new System.Windows.Forms.Label();
            this.txtSizeId = new System.Windows.Forms.TextBox();
            this.lblNameMH = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.lblCodeMH = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(47, 497);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 29;
            this.dgvCTHD.Size = new System.Drawing.Size(1162, 252);
            this.dgvCTHD.TabIndex = 26;
            this.dgvCTHD.SelectionChanged += new System.EventHandler(this.dgvCTHD_SelectionChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(495, 193);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(165, 32);
            this.txtTongTien.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(368, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tổng tiền:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLamMoi.Location = new System.Drawing.Point(468, 265);
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
            this.btnSua.Location = new System.Drawing.Point(289, 265);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 35);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.BackgroundImage = global::QuanLyBanHangStarbucks.Properties.Resources.house_chimney_window;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(1168, 22);
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
            this.groupBox2.Controls.Add(this.rdProductId);
            this.groupBox2.Controls.Add(this.btnSau);
            this.groupBox2.Controls.Add(this.rdBillId);
            this.groupBox2.Controls.Add(this.btnTruoc);
            this.groupBox2.Controls.Add(this.btnDau);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(754, 138);
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
            // rdProductId
            // 
            this.rdProductId.AutoSize = true;
            this.rdProductId.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdProductId.Location = new System.Drawing.Point(251, 39);
            this.rdProductId.Name = "rdProductId";
            this.rdProductId.Size = new System.Drawing.Size(136, 25);
            this.rdProductId.TabIndex = 1;
            this.rdProductId.TabStop = true;
            this.rdProductId.Text = "Id mặt hàng";
            this.rdProductId.UseVisualStyleBackColor = true;
            this.rdProductId.CheckedChanged += new System.EventHandler(this.rdProductId_CheckedChanged);
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
            // rdBillId
            // 
            this.rdBillId.AutoSize = true;
            this.rdBillId.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdBillId.Location = new System.Drawing.Point(31, 41);
            this.rdBillId.Name = "rdBillId";
            this.rdBillId.Size = new System.Drawing.Size(125, 25);
            this.rdBillId.TabIndex = 0;
            this.rdBillId.TabStop = true;
            this.rdBillId.Text = "Id hóa đơn";
            this.rdBillId.UseVisualStyleBackColor = true;
            this.rdBillId.CheckedChanged += new System.EventHandler(this.rdBillId_CheckedChanged);
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
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnXoa.Location = new System.Drawing.Point(94, 265);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 35);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.lblUnitMH.Location = new System.Drawing.Point(22, 199);
            this.lblUnitMH.Name = "lblUnitMH";
            this.lblUnitMH.Size = new System.Drawing.Size(82, 21);
            this.lblUnitMH.TabIndex = 6;
            this.lblUnitMH.Text = "Đơn giá:";
            // 
            // txtPriceId
            // 
            this.txtPriceId.Location = new System.Drawing.Point(185, 193);
            this.txtPriceId.Name = "txtPriceId";
            this.txtPriceId.Size = new System.Drawing.Size(165, 32);
            this.txtPriceId.TabIndex = 5;
            // 
            // lblCategoryMH
            // 
            this.lblCategoryMH.AutoSize = true;
            this.lblCategoryMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryMH.Location = new System.Drawing.Point(370, 43);
            this.lblCategoryMH.Name = "lblCategoryMH";
            this.lblCategoryMH.Size = new System.Drawing.Size(121, 21);
            this.lblCategoryMH.TabIndex = 4;
            this.lblCategoryMH.Text = "Id mặt hàng:";
            // 
            // txtSizeId
            // 
            this.txtSizeId.Location = new System.Drawing.Point(185, 110);
            this.txtSizeId.Name = "txtSizeId";
            this.txtSizeId.Size = new System.Drawing.Size(165, 32);
            this.txtSizeId.TabIndex = 3;
            // 
            // lblNameMH
            // 
            this.lblNameMH.AutoSize = true;
            this.lblNameMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameMH.Location = new System.Drawing.Point(22, 115);
            this.lblNameMH.Name = "lblNameMH";
            this.lblNameMH.Size = new System.Drawing.Size(73, 21);
            this.lblNameMH.TabIndex = 2;
            this.lblNameMH.Text = "Id size:";
            // 
            // txtBillId
            // 
            this.txtBillId.Location = new System.Drawing.Point(185, 36);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(165, 32);
            this.txtBillId.TabIndex = 1;
            // 
            // lblCodeMH
            // 
            this.lblCodeMH.AutoSize = true;
            this.lblCodeMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodeMH.Location = new System.Drawing.Point(22, 43);
            this.lblCodeMH.Name = "lblCodeMH";
            this.lblCodeMH.Size = new System.Drawing.Size(110, 21);
            this.lblCodeMH.TabIndex = 0;
            this.lblCodeMH.Text = "Id hóa đơn:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtProductId);
            this.groupBox1.Controls.Add(this.lblUnitMH);
            this.groupBox1.Controls.Add(this.txtPriceId);
            this.groupBox1.Controls.Add(this.lblCategoryMH);
            this.groupBox1.Controls.Add(this.txtSizeId);
            this.groupBox1.Controls.Add(this.lblNameMH);
            this.groupBox1.Controls.Add(this.txtBillId);
            this.groupBox1.Controls.Add(this.lblCodeMH);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(47, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 335);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(495, 109);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(165, 32);
            this.txtSoLuong.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(370, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(470, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 40);
            this.label1.TabIndex = 24;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // Frm09ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHangStarbucks.Properties.Resources.bg9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 797);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm09ChiTietHoaDon";
            this.Text = "Frm09ChiTietHoaDon";
            this.Load += new System.EventHandler(this.Frm09ChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTruoc;
        private DataGridView dgvCTHD;
        private TextBox txtTongTien;
        private Label label4;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnHome;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private GroupBox groupBox3;
        private TextBox txtTimKiem;
        private Button btnCuoi;
        private RadioButton rdProductId;
        private Button btnSau;
        private RadioButton rdBillId;
        private Button btnDau;
        private Button btnXoa;
        private TextBox txtProductId;
        private Label lblUnitMH;
        private TextBox txtPriceId;
        private Label lblCategoryMH;
        private TextBox txtSizeId;
        private Label lblNameMH;
        private TextBox txtBillId;
        private Label lblCodeMH;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtSoLuong;
        private Label label5;
    }
}