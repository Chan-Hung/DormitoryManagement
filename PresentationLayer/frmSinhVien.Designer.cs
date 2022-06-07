
namespace DormitoryManagement.PresentationLayer
{
    partial class frmSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.rbSearchMaSV = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.masv1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbSearchTenSV = new System.Windows.Forms.RadioButton();
            this.btnTien = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.gioitinh1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.sdt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSinhvien = new System.Windows.Forms.DataGridView();
            this.tensv1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matruong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.rbSearchToa = new System.Windows.Forms.RadioButton();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.txtMaTruong = new System.Windows.Forms.TextBox();
            this.txtTensv = new System.Windows.Forms.TextBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSearchMaSV
            // 
            this.rbSearchMaSV.AutoSize = true;
            this.rbSearchMaSV.Checked = true;
            this.rbSearchMaSV.Location = new System.Drawing.Point(28, 23);
            this.rbSearchMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.rbSearchMaSV.Name = "rbSearchMaSV";
            this.rbSearchMaSV.Size = new System.Drawing.Size(162, 21);
            this.rbSearchMaSV.TabIndex = 0;
            this.rbSearchMaSV.TabStop = true;
            this.rbSearchMaSV.Text = "Tìm kiếm theo mã SV";
            this.rbSearchMaSV.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.Location = new System.Drawing.Point(24, 168);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnTimkiem.Size = new System.Drawing.Size(184, 46);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(24, 138);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(184, 24);
            this.txtTimkiem.TabIndex = 2;
            // 
            // masv1
            // 
            this.masv1.DataPropertyName = "masv";
            this.masv1.HeaderText = "Mã sinh viên";
            this.masv1.MinimumWidth = 6;
            this.masv1.Name = "masv1";
            this.masv1.ReadOnly = true;
            this.masv1.Width = 70;
            // 
            // rbSearchTenSV
            // 
            this.rbSearchTenSV.AutoSize = true;
            this.rbSearchTenSV.Location = new System.Drawing.Point(28, 52);
            this.rbSearchTenSV.Margin = new System.Windows.Forms.Padding(4);
            this.rbSearchTenSV.Name = "rbSearchTenSV";
            this.rbSearchTenSV.Size = new System.Drawing.Size(163, 21);
            this.rbSearchTenSV.TabIndex = 1;
            this.rbSearchTenSV.Text = "Tìm kiếm theo tên SV";
            this.rbSearchTenSV.UseVisualStyleBackColor = true;
            // 
            // btnTien
            // 
            this.btnTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTien.FlatAppearance.BorderSize = 0;
            this.btnTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTien.Image = ((System.Drawing.Image)(resources.GetObject("btnTien.Image")));
            this.btnTien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTien.Location = new System.Drawing.Point(867, 498);
            this.btnTien.Margin = new System.Windows.Forms.Padding(4);
            this.btnTien.Name = "btnTien";
            this.btnTien.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnTien.Size = new System.Drawing.Size(99, 74);
            this.btnTien.TabIndex = 120;
            this.btnTien.Text = "Giá Phòng";
            this.btnTien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTien.UseVisualStyleBackColor = true;
            this.btnTien.Click += new System.EventHandler(this.btnTien_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(767, 255);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnThem.Size = new System.Drawing.Size(80, 74);
            this.btnThem.TabIndex = 119;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblSDT
            // 
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(380, 55);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(140, 21);
            this.lblSDT.TabIndex = 114;
            this.lblSDT.Text = "Số điện thoại";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(528, 136);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(159, 22);
            this.txtMaPhong.TabIndex = 110;
            // 
            // gioitinh1
            // 
            this.gioitinh1.DataPropertyName = "gioitinh";
            this.gioitinh1.HeaderText = "Giới tính";
            this.gioitinh1.MinimumWidth = 6;
            this.gioitinh1.Name = "gioitinh1";
            this.gioitinh1.ReadOnly = true;
            this.gioitinh1.Width = 60;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(768, 417);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnXoa.Size = new System.Drawing.Size(80, 74);
            this.btnXoa.TabIndex = 116;
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
            this.btnSua.Location = new System.Drawing.Point(768, 335);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnSua.Size = new System.Drawing.Size(80, 74);
            this.btnSua.TabIndex = 115;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // sdt1
            // 
            this.sdt1.DataPropertyName = "sdt";
            this.sdt1.HeaderText = "Số điện thoại";
            this.sdt1.MinimumWidth = 6;
            this.sdt1.Name = "sdt1";
            this.sdt1.ReadOnly = true;
            this.sdt1.Width = 120;
            // 
            // dgvSinhvien
            // 
            this.dgvSinhvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv1,
            this.tensv1,
            this.gioitinh1,
            this.sdt1,
            this.matruong1,
            this.maphong1});
            this.dgvSinhvien.Location = new System.Drawing.Point(13, 195);
            this.dgvSinhvien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSinhvien.Name = "dgvSinhvien";
            this.dgvSinhvien.ReadOnly = true;
            this.dgvSinhvien.RowHeadersWidth = 51;
            this.dgvSinhvien.Size = new System.Drawing.Size(742, 383);
            this.dgvSinhvien.TabIndex = 117;
            this.dgvSinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhvien_CellClick);
            // 
            // tensv1
            // 
            this.tensv1.DataPropertyName = "tensv";
            this.tensv1.HeaderText = "Tên sinh viên";
            this.tensv1.MinimumWidth = 6;
            this.tensv1.Name = "tensv1";
            this.tensv1.ReadOnly = true;
            this.tensv1.Width = 110;
            // 
            // matruong1
            // 
            this.matruong1.DataPropertyName = "matruong";
            this.matruong1.HeaderText = "Mã trường";
            this.matruong1.MinimumWidth = 6;
            this.matruong1.Name = "matruong1";
            this.matruong1.ReadOnly = true;
            this.matruong1.Width = 70;
            // 
            // maphong1
            // 
            this.maphong1.DataPropertyName = "maphong";
            this.maphong1.HeaderText = "Mã phòng";
            this.maphong1.MinimumWidth = 6;
            this.maphong1.Name = "maphong1";
            this.maphong1.ReadOnly = true;
            this.maphong1.Width = 70;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(768, 499);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnRefresh.Size = new System.Drawing.Size(80, 74);
            this.btnRefresh.TabIndex = 118;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(528, 53);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(159, 22);
            this.txtSDT.TabIndex = 108;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapnhat.FlatAppearance.BorderSize = 0;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapnhat.Location = new System.Drawing.Point(1370, 264);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnCapnhat.Size = new System.Drawing.Size(80, 74);
            this.btnCapnhat.TabIndex = 113;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapnhat.UseVisualStyleBackColor = true;
            // 
            // rbSearchToa
            // 
            this.rbSearchToa.AutoSize = true;
            this.rbSearchToa.Location = new System.Drawing.Point(28, 81);
            this.rbSearchToa.Margin = new System.Windows.Forms.Padding(4);
            this.rbSearchToa.Name = "rbSearchToa";
            this.rbSearchToa.Size = new System.Drawing.Size(141, 21);
            this.rbSearchToa.TabIndex = 9;
            this.rbSearchToa.Text = "Tìm kiếm theo tòa";
            this.rbSearchToa.UseVisualStyleBackColor = true;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbGioitinh.Location = new System.Drawing.Point(129, 134);
            this.cbGioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(159, 24);
            this.cbGioitinh.TabIndex = 106;
            // 
            // txtMaTruong
            // 
            this.txtMaTruong.Location = new System.Drawing.Point(528, 95);
            this.txtMaTruong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTruong.Name = "txtMaTruong";
            this.txtMaTruong.Size = new System.Drawing.Size(159, 22);
            this.txtMaTruong.TabIndex = 109;
            // 
            // txtTensv
            // 
            this.txtTensv.Location = new System.Drawing.Point(129, 95);
            this.txtTensv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTensv.Name = "txtTensv";
            this.txtTensv.Size = new System.Drawing.Size(159, 22);
            this.txtTensv.TabIndex = 104;
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(129, 54);
            this.txtMasv.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(159, 22);
            this.txtMasv.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 112;
            this.label8.Text = "Mã phòng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 111;
            this.label5.Text = "Mã trường";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 107;
            this.label3.Text = "Giới tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenSV
            // 
            this.lblTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(4, 93);
            this.lblTenSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(119, 22);
            this.lblTenSV.TabIndex = 105;
            this.lblTenSV.Text = "Tên sinh viên";
            this.lblTenSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbSearchToa);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rbSearchMaSV);
            this.groupBox1.Controls.Add(this.rbSearchTenSV);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Location = new System.Drawing.Point(739, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(227, 222);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÌM KIẾM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Nhập thông tin tìm kiếm:";
            // 
            // lblMaSV
            // 
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(4, 53);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(119, 21);
            this.lblMaSV.TabIndex = 102;
            this.lblMaSV.Text = "Mã sinh viên";
            this.lblMaSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(867, 255);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnLuu.Size = new System.Drawing.Size(80, 74);
            this.btnLuu.TabIndex = 121;
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
            this.btnHuy.Location = new System.Drawing.Point(867, 335);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnHuy.Size = new System.Drawing.Size(80, 74);
            this.btnHuy.TabIndex = 122;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 603);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvSinhvien);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.cbGioitinh);
            this.Controls.Add(this.txtMaTruong);
            this.Controls.Add(this.txtTensv);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMaSV);
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSearchMaSV;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv1;
        private System.Windows.Forms.RadioButton rbSearchTenSV;
        private System.Windows.Forms.Button btnTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt1;
        private System.Windows.Forms.DataGridView dgvSinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matruong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.RadioButton rbSearchToa;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.TextBox txtMaTruong;
        private System.Windows.Forms.TextBox txtTensv;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}