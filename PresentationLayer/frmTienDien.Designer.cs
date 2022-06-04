
namespace DormitoryManagement.PresentationLayer
{
    partial class frmTienDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTienDien));
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaylap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonuoctieuthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPhongChuaThanhToan = new System.Windows.Forms.Button();
            this.sodientieuthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoDienTieuThu = new System.Windows.Forms.DataGridView();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoNuocTieuThu = new System.Windows.Forms.TextBox();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblSoDienTieuThu = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.txtSoDienTieuThu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoDienTieuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThanhToan.Location = new System.Drawing.Point(220, 108);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnThanhToan.Size = new System.Drawing.Size(99, 74);
            this.btnThanhToan.TabIndex = 121;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cbTrangThai.Location = new System.Drawing.Point(160, 471);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(159, 24);
            this.cbTrangThai.TabIndex = 119;
            this.cbTrangThai.Text = "Chưa thanh toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 406);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 118;
            this.label1.Text = "Số nước tiêu thụ";
            // 
            // dtpNgaylap
            // 
            this.dtpNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylap.Location = new System.Drawing.Point(160, 297);
            this.dtpNgaylap.Name = "dtpNgaylap";
            this.dtpNgaylap.Size = new System.Drawing.Size(159, 22);
            this.dtpNgaylap.TabIndex = 117;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.Location = new System.Drawing.Point(8, 297);
            this.lblNgayLap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(150, 22);
            this.lblNgayLap.TabIndex = 116;
            this.lblNgayLap.Text = "Ngày lập hóa đơn";
            this.lblNgayLap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(697, 108);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnRefresh.Size = new System.Drawing.Size(80, 74);
            this.btnRefresh.TabIndex = 115;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(584, 108);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnXoa.Size = new System.Drawing.Size(80, 74);
            this.btnXoa.TabIndex = 112;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(468, 108);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnSua.Size = new System.Drawing.Size(80, 74);
            this.btnSua.TabIndex = 113;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(345, 108);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnThem.Size = new System.Drawing.Size(80, 74);
            this.btnThem.TabIndex = 114;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.Width = 125;
            // 
            // sonuoctieuthu
            // 
            this.sonuoctieuthu.DataPropertyName = "sonuoctieuthu";
            this.sonuoctieuthu.HeaderText = "Số nước tiêu thụ";
            this.sonuoctieuthu.MinimumWidth = 6;
            this.sonuoctieuthu.Name = "sonuoctieuthu";
            this.sonuoctieuthu.Width = 70;
            // 
            // btnPhongChuaThanhToan
            // 
            this.btnPhongChuaThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPhongChuaThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhongChuaThanhToan.Location = new System.Drawing.Point(795, 124);
            this.btnPhongChuaThanhToan.Name = "btnPhongChuaThanhToan";
            this.btnPhongChuaThanhToan.Size = new System.Drawing.Size(132, 43);
            this.btnPhongChuaThanhToan.TabIndex = 120;
            this.btnPhongChuaThanhToan.Text = "Hiển thị phòng chưa thanh toán";
            this.btnPhongChuaThanhToan.UseVisualStyleBackColor = false;
            this.btnPhongChuaThanhToan.Click += new System.EventHandler(this.btnPhongChuaThanhToan_Click);
            // 
            // sodientieuthu
            // 
            this.sodientieuthu.DataPropertyName = "sodientieuthu";
            this.sodientieuthu.HeaderText = "Số điện tiêu thụ";
            this.sodientieuthu.MinimumWidth = 6;
            this.sodientieuthu.Name = "sodientieuthu";
            this.sodientieuthu.Width = 70;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.Width = 60;
            // 
            // mahoadon
            // 
            this.mahoadon.DataPropertyName = "mahoadon";
            this.mahoadon.HeaderText = "Mã hóa đơn";
            this.mahoadon.MinimumWidth = 6;
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.Width = 70;
            // 
            // dgvSoDienTieuThu
            // 
            this.dgvSoDienTieuThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSoDienTieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoDienTieuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.maphong,
            this.ngaylap,
            this.sodientieuthu,
            this.sonuoctieuthu,
            this.trangthai});
            this.dgvSoDienTieuThu.Location = new System.Drawing.Point(343, 190);
            this.dgvSoDienTieuThu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSoDienTieuThu.Name = "dgvSoDienTieuThu";
            this.dgvSoDienTieuThu.RowHeadersWidth = 51;
            this.dgvSoDienTieuThu.Size = new System.Drawing.Size(627, 305);
            this.dgvSoDienTieuThu.TabIndex = 111;
            this.dgvSoDienTieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoDienTieuThu_CellClick);
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.Width = 110;
            // 
            // txtSoNuocTieuThu
            // 
            this.txtSoNuocTieuThu.Location = new System.Drawing.Point(160, 405);
            this.txtSoNuocTieuThu.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNuocTieuThu.Name = "txtSoNuocTieuThu";
            this.txtSoNuocTieuThu.Size = new System.Drawing.Size(159, 22);
            this.txtSoNuocTieuThu.TabIndex = 106;
            this.txtSoNuocTieuThu.Text = "0";
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTri.Location = new System.Drawing.Point(9, 471);
            this.lblGiaTri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(130, 18);
            this.lblGiaTri.TabIndex = 110;
            this.lblGiaTri.Text = "Trạng thái";
            this.lblGiaTri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(160, 246);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(159, 22);
            this.txtMaPhong.TabIndex = 104;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(160, 190);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(159, 22);
            this.txtMaHoaDon.TabIndex = 103;
            // 
            // lblSoDienTieuThu
            // 
            this.lblSoDienTieuThu.AutoSize = true;
            this.lblSoDienTieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienTieuThu.Location = new System.Drawing.Point(30, 346);
            this.lblSoDienTieuThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDienTieuThu.Name = "lblSoDienTieuThu";
            this.lblSoDienTieuThu.Size = new System.Drawing.Size(109, 18);
            this.lblSoDienTieuThu.TabIndex = 109;
            this.lblSoDienTieuThu.Text = "Số điện tiêu thụ";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(30, 245);
            this.lblMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(97, 22);
            this.lblMaPhong.TabIndex = 108;
            this.lblMaPhong.Text = "Mã phòng";
            this.lblMaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(27, 191);
            this.lblMaHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(100, 21);
            this.lblMaHoaDon.TabIndex = 107;
            this.lblMaHoaDon.Text = "Mã hóa đơn";
            this.lblMaHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoDienTieuThu
            // 
            this.txtSoDienTieuThu.Location = new System.Drawing.Point(160, 346);
            this.txtSoDienTieuThu.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDienTieuThu.Name = "txtSoDienTieuThu";
            this.txtSoDienTieuThu.Size = new System.Drawing.Size(159, 22);
            this.txtSoDienTieuThu.TabIndex = 105;
            this.txtSoDienTieuThu.Text = "0";
            // 
            // frmTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 603);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgaylap);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnPhongChuaThanhToan);
            this.Controls.Add(this.dgvSoDienTieuThu);
            this.Controls.Add(this.txtSoNuocTieuThu);
            this.Controls.Add(this.lblGiaTri);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.lblSoDienTieuThu);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblMaHoaDon);
            this.Controls.Add(this.txtSoDienTieuThu);
            this.Name = "frmTienDien";
            this.Text = "frmTienDien";
            this.Load += new System.EventHandler(this.frmTienDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoDienTieuThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaylap;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonuoctieuthu;
        private System.Windows.Forms.Button btnPhongChuaThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodientieuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridView dgvSoDienTieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.TextBox txtSoNuocTieuThu;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblSoDienTieuThu;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.TextBox txtSoDienTieuThu;
    }
}