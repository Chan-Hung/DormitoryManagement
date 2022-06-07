
namespace DormitoryManagement.PresentationLayer
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.cbMaLoaiNV = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbSearchMaNV = new System.Windows.Forms.RadioButton();
            this.rbSearchTenNV = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloainv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaToa = new System.Windows.Forms.Label();
            this.lblMaLoaiNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.rbSearchToa = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaLoaiNV
            // 
            this.cbMaLoaiNV.FormattingEnabled = true;
            this.cbMaLoaiNV.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07"});
            this.cbMaLoaiNV.Location = new System.Drawing.Point(150, 90);
            this.cbMaLoaiNV.Name = "cbMaLoaiNV";
            this.cbMaLoaiNV.Size = new System.Drawing.Size(159, 24);
            this.cbMaLoaiNV.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Nhập thông tin tìm kiếm:";
            // 
            // rbSearchMaNV
            // 
            this.rbSearchMaNV.AutoSize = true;
            this.rbSearchMaNV.Location = new System.Drawing.Point(28, 23);
            this.rbSearchMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.rbSearchMaNV.Name = "rbSearchMaNV";
            this.rbSearchMaNV.Size = new System.Drawing.Size(163, 21);
            this.rbSearchMaNV.TabIndex = 0;
            this.rbSearchMaNV.TabStop = true;
            this.rbSearchMaNV.Text = "Tìm kiếm theo mã NV";
            this.rbSearchMaNV.UseVisualStyleBackColor = true;
            // 
            // rbSearchTenNV
            // 
            this.rbSearchTenNV.AutoSize = true;
            this.rbSearchTenNV.Location = new System.Drawing.Point(28, 52);
            this.rbSearchTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.rbSearchTenNV.Name = "rbSearchTenNV";
            this.rbSearchTenNV.Size = new System.Drawing.Size(164, 21);
            this.rbSearchTenNV.TabIndex = 1;
            this.rbSearchTenNV.TabStop = true;
            this.rbSearchTenNV.Text = "Tìm kiếm theo tên NV";
            this.rbSearchTenNV.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.Location = new System.Drawing.Point(19, 161);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnTimkiem.Size = new System.Drawing.Size(184, 55);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(19, 131);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(184, 24);
            this.txtTimkiem.TabIndex = 2;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(538, 134);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(159, 22);
            this.txtLuong.TabIndex = 58;
            this.txtLuong.Text = "0";
            // 
            // txtMaToa
            // 
            this.txtMaToa.Location = new System.Drawing.Point(150, 135);
            this.txtMaToa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaToa.Name = "txtMaToa";
            this.txtMaToa.Size = new System.Drawing.Size(159, 22);
            this.txtMaToa.TabIndex = 53;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(783, 415);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnXoa.Size = new System.Drawing.Size(80, 74);
            this.btnXoa.TabIndex = 65;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(783, 333);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnSua.Size = new System.Drawing.Size(80, 74);
            this.btnSua.TabIndex = 64;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(783, 251);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnThem.Size = new System.Drawing.Size(80, 74);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbSearchToa);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rbSearchMaNV);
            this.groupBox1.Controls.Add(this.rbSearchTenNV);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Location = new System.Drawing.Point(763, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(214, 224);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÌM KIẾM";
            // 
            // luong
            // 
            this.luong.DataPropertyName = "luong";
            this.luong.HeaderText = "Lương";
            this.luong.MinimumWidth = 6;
            this.luong.Name = "luong";
            this.luong.Width = 65;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(783, 497);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnRefresh.Size = new System.Drawing.Size(80, 74);
            this.btnRefresh.TabIndex = 67;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // matoa
            // 
            this.matoa.DataPropertyName = "matoa";
            this.matoa.HeaderText = "Mã tòa";
            this.matoa.MinimumWidth = 6;
            this.matoa.Name = "matoa";
            this.matoa.Width = 40;
            // 
            // maloainv
            // 
            this.maloainv.DataPropertyName = "maloainv";
            this.maloainv.HeaderText = "Mã loại nhân viên";
            this.maloainv.MinimumWidth = 6;
            this.maloainv.Name = "maloainv";
            this.maloainv.Width = 70;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 85;
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.maloainv,
            this.matoa,
            this.tennv,
            this.SDT,
            this.luong});
            this.dgvNhanvien.Location = new System.Drawing.Point(27, 188);
            this.dgvNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 51;
            this.dgvNhanvien.Size = new System.Drawing.Size(748, 383);
            this.dgvNhanvien.TabIndex = 62;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick);
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.MinimumWidth = 6;
            this.tennv.Name = "tennv";
            this.tennv.Width = 120;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(538, 87);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(159, 22);
            this.txtSDT.TabIndex = 57;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(538, 46);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(159, 22);
            this.txtTenNV.TabIndex = 56;
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.Location = new System.Drawing.Point(412, 139);
            this.lblLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(49, 18);
            this.lblLuong.TabIndex = 61;
            this.lblLuong.Text = "Lương";
            // 
            // lblSDT
            // 
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(412, 91);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(119, 22);
            this.lblSDT.TabIndex = 60;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblTenNV
            // 
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(412, 50);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(119, 21);
            this.lblTenNV.TabIndex = 59;
            this.lblTenNV.Text = "Tên nhân viên";
            // 
            // lblMaToa
            // 
            this.lblMaToa.AutoSize = true;
            this.lblMaToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaToa.Location = new System.Drawing.Point(24, 135);
            this.lblMaToa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaToa.Name = "lblMaToa";
            this.lblMaToa.Size = new System.Drawing.Size(54, 18);
            this.lblMaToa.TabIndex = 55;
            this.lblMaToa.Text = "Mã tòa";
            // 
            // lblMaLoaiNV
            // 
            this.lblMaLoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoaiNV.Location = new System.Drawing.Point(2, 90);
            this.lblMaLoaiNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLoaiNV.Name = "lblMaLoaiNV";
            this.lblMaLoaiNV.Size = new System.Drawing.Size(150, 22);
            this.lblMaLoaiNV.TabIndex = 54;
            this.lblMaLoaiNV.Text = "Mã loại nhân viên";
            this.lblMaLoaiNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(24, 54);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(119, 21);
            this.lblMaNV.TabIndex = 51;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(150, 50);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(159, 22);
            this.txtMaNV.TabIndex = 52;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(875, 251);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnLuu.Size = new System.Drawing.Size(80, 74);
            this.btnLuu.TabIndex = 123;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(875, 333);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnHuy.Size = new System.Drawing.Size(80, 74);
            this.btnHuy.TabIndex = 123;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // rbSearchToa
            // 
            this.rbSearchToa.AutoSize = true;
            this.rbSearchToa.Location = new System.Drawing.Point(28, 81);
            this.rbSearchToa.Margin = new System.Windows.Forms.Padding(4);
            this.rbSearchToa.Name = "rbSearchToa";
            this.rbSearchToa.Size = new System.Drawing.Size(141, 21);
            this.rbSearchToa.TabIndex = 124;
            this.rbSearchToa.Text = "Tìm kiếm theo tòa";
            this.rbSearchToa.UseVisualStyleBackColor = true;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 603);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbMaLoaiNV);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtMaToa);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblMaToa);
            this.Controls.Add(this.lblMaLoaiNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaLoaiNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbSearchMaNV;
        private System.Windows.Forms.RadioButton rbSearchTenNV;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn matoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloainv;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaToa;
        private System.Windows.Forms.Label lblMaLoaiNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.RadioButton rbSearchToa;
    }
}