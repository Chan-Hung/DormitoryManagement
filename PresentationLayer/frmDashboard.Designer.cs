
namespace DormitoryManagement.PresentationLayer
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DateLabel = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.btnTuyChon = new System.Windows.Forms.Button();
            this.panelTime = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlTuyChonSubMenu = new System.Windows.Forms.Panel();
            this.btnQLHopDong = new System.Windows.Forms.Button();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.btnQLSinhVien = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnQLPhong = new System.Windows.Forms.Button();
            this.btnQLToa = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnDichVuSuDung = new System.Windows.Forms.Button();
            this.pnlToaPhongSubMenu = new System.Windows.Forms.Panel();
            this.btnToaVaPhong = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelTime.SuspendLayout();
            this.pnlTuyChonSubMenu.SuspendLayout();
            this.pnlToaPhongSubMenu.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Image = ((System.Drawing.Image)(resources.GetObject("DateLabel.Image")));
            this.DateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DateLabel.Location = new System.Drawing.Point(0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.DateLabel.Size = new System.Drawing.Size(313, 50);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "ddd, d MMMM yyyy";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // ClockLabel
            // 
            this.ClockLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.ClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ClockLabel.ForeColor = System.Drawing.Color.White;
            this.ClockLabel.Image = ((System.Drawing.Image)(resources.GetObject("ClockLabel.Image")));
            this.ClockLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClockLabel.Location = new System.Drawing.Point(0, 50);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.ClockLabel.Size = new System.Drawing.Size(313, 50);
            this.ClockLabel.TabIndex = 0;
            this.ClockLabel.Text = "HH:mm:ss";
            this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClockLabel.Click += new System.EventHandler(this.ClockLabel_Click);
            // 
            // btnTuyChon
            // 
            this.btnTuyChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnTuyChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuyChon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTuyChon.FlatAppearance.BorderSize = 0;
            this.btnTuyChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTuyChon.ForeColor = System.Drawing.Color.White;
            this.btnTuyChon.Image = ((System.Drawing.Image)(resources.GetObject("btnTuyChon.Image")));
            this.btnTuyChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTuyChon.Location = new System.Drawing.Point(0, 169);
            this.btnTuyChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTuyChon.Name = "btnTuyChon";
            this.btnTuyChon.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnTuyChon.Size = new System.Drawing.Size(292, 55);
            this.btnTuyChon.TabIndex = 1;
            this.btnTuyChon.Text = "Tùy chọn";
            this.btnTuyChon.UseVisualStyleBackColor = false;
            this.btnTuyChon.Click += new System.EventHandler(this.btnTuyChon_Click_1);
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(147)))));
            this.panelTime.Controls.Add(this.DateLabel);
            this.panelTime.Controls.Add(this.ClockLabel);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTime.Location = new System.Drawing.Point(0, 0);
            this.panelTime.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(292, 169);
            this.panelTime.TabIndex = 0;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(313, 0);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(5);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(999, 683);
            this.pnlChildForm.TabIndex = 3;
            // 
            // pnlTuyChonSubMenu
            // 
            this.pnlTuyChonSubMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTuyChonSubMenu.Controls.Add(this.btnQLHopDong);
            this.pnlTuyChonSubMenu.Controls.Add(this.btnQLTaiKhoan);
            this.pnlTuyChonSubMenu.Controls.Add(this.btnQLSinhVien);
            this.pnlTuyChonSubMenu.Controls.Add(this.btnQLNhanVien);
            this.pnlTuyChonSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTuyChonSubMenu.Location = new System.Drawing.Point(0, 224);
            this.pnlTuyChonSubMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlTuyChonSubMenu.Name = "pnlTuyChonSubMenu";
            this.pnlTuyChonSubMenu.Size = new System.Drawing.Size(292, 155);
            this.pnlTuyChonSubMenu.TabIndex = 2;
            // 
            // btnQLHopDong
            // 
            this.btnQLHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(147)))));
            this.btnQLHopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLHopDong.FlatAppearance.BorderSize = 0;
            this.btnQLHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLHopDong.ForeColor = System.Drawing.Color.White;
            this.btnQLHopDong.Image = ((System.Drawing.Image)(resources.GetObject("btnQLHopDong.Image")));
            this.btnQLHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHopDong.Location = new System.Drawing.Point(0, 117);
            this.btnQLHopDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLHopDong.Name = "btnQLHopDong";
            this.btnQLHopDong.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLHopDong.Size = new System.Drawing.Size(292, 42);
            this.btnQLHopDong.TabIndex = 3;
            this.btnQLHopDong.Text = "Theo dõi hợp đồng";
            this.btnQLHopDong.UseVisualStyleBackColor = false;
            this.btnQLHopDong.Click += new System.EventHandler(this.btnQLHopDong_Click);
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(147)))));
            this.btnQLTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQLTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnQLTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTaiKhoan.Image")));
            this.btnQLTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(0, 78);
            this.btnQLTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(292, 39);
            this.btnQLTaiKhoan.TabIndex = 2;
            this.btnQLTaiKhoan.Text = "Quản lý tài khoản";
            this.btnQLTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            // 
            // btnQLSinhVien
            // 
            this.btnQLSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(147)))));
            this.btnQLSinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLSinhVien.FlatAppearance.BorderSize = 0;
            this.btnQLSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnQLSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSinhVien.Image")));
            this.btnQLSinhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSinhVien.Location = new System.Drawing.Point(0, 39);
            this.btnQLSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLSinhVien.Name = "btnQLSinhVien";
            this.btnQLSinhVien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLSinhVien.Size = new System.Drawing.Size(292, 39);
            this.btnQLSinhVien.TabIndex = 1;
            this.btnQLSinhVien.Text = "Quản lý sinh viên";
            this.btnQLSinhVien.UseVisualStyleBackColor = false;
            this.btnQLSinhVien.Click += new System.EventHandler(this.btnQLSinhVien_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(147)))));
            this.btnQLNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQLNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNhanVien.Image")));
            this.btnQLNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnQLNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLNhanVien.Size = new System.Drawing.Size(292, 39);
            this.btnQLNhanVien.TabIndex = 0;
            this.btnQLNhanVien.Text = "Quản lý nhân viên";
            this.btnQLNhanVien.UseVisualStyleBackColor = false;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // btnQLPhong
            // 
            this.btnQLPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(147)))));
            this.btnQLPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLPhong.FlatAppearance.BorderSize = 0;
            this.btnQLPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLPhong.ForeColor = System.Drawing.Color.White;
            this.btnQLPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnQLPhong.Image")));
            this.btnQLPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhong.Location = new System.Drawing.Point(0, 43);
            this.btnQLPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLPhong.Name = "btnQLPhong";
            this.btnQLPhong.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLPhong.Size = new System.Drawing.Size(292, 47);
            this.btnQLPhong.TabIndex = 1;
            this.btnQLPhong.Text = "Quản lý phòng";
            this.btnQLPhong.UseVisualStyleBackColor = false;
            this.btnQLPhong.Click += new System.EventHandler(this.btnQLPhong_Click);
            // 
            // btnQLToa
            // 
            this.btnQLToa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(147)))));
            this.btnQLToa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLToa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLToa.FlatAppearance.BorderSize = 0;
            this.btnQLToa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLToa.ForeColor = System.Drawing.Color.White;
            this.btnQLToa.Image = ((System.Drawing.Image)(resources.GetObject("btnQLToa.Image")));
            this.btnQLToa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLToa.Location = new System.Drawing.Point(0, 0);
            this.btnQLToa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLToa.Name = "btnQLToa";
            this.btnQLToa.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQLToa.Size = new System.Drawing.Size(292, 43);
            this.btnQLToa.TabIndex = 0;
            this.btnQLToa.Text = "Quản lý tòa";
            this.btnQLToa.UseVisualStyleBackColor = false;
            this.btnQLToa.Click += new System.EventHandler(this.btnQLToa_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 630);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(292, 55);
            this.btnDangXuat.TabIndex = 9;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Image")));
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(0, 575);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDoiMatKhau.Size = new System.Drawing.Size(292, 55);
            this.btnDoiMatKhau.TabIndex = 8;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnDichVuSuDung
            // 
            this.btnDichVuSuDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnDichVuSuDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDichVuSuDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDichVuSuDung.FlatAppearance.BorderSize = 0;
            this.btnDichVuSuDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVuSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDichVuSuDung.ForeColor = System.Drawing.Color.White;
            this.btnDichVuSuDung.Image = ((System.Drawing.Image)(resources.GetObject("btnDichVuSuDung.Image")));
            this.btnDichVuSuDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVuSuDung.Location = new System.Drawing.Point(0, 524);
            this.btnDichVuSuDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDichVuSuDung.Name = "btnDichVuSuDung";
            this.btnDichVuSuDung.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDichVuSuDung.Size = new System.Drawing.Size(292, 51);
            this.btnDichVuSuDung.TabIndex = 7;
            this.btnDichVuSuDung.Text = "Điện nước sử dụng";
            this.btnDichVuSuDung.UseVisualStyleBackColor = false;
            this.btnDichVuSuDung.Click += new System.EventHandler(this.btnDichVuSuDung_Click);
            // 
            // pnlToaPhongSubMenu
            // 
            this.pnlToaPhongSubMenu.Controls.Add(this.btnQLPhong);
            this.pnlToaPhongSubMenu.Controls.Add(this.btnQLToa);
            this.pnlToaPhongSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToaPhongSubMenu.Location = new System.Drawing.Point(0, 434);
            this.pnlToaPhongSubMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlToaPhongSubMenu.Name = "pnlToaPhongSubMenu";
            this.pnlToaPhongSubMenu.Size = new System.Drawing.Size(292, 90);
            this.pnlToaPhongSubMenu.TabIndex = 6;
            // 
            // btnToaVaPhong
            // 
            this.btnToaVaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnToaVaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToaVaPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToaVaPhong.FlatAppearance.BorderSize = 0;
            this.btnToaVaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToaVaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnToaVaPhong.ForeColor = System.Drawing.Color.White;
            this.btnToaVaPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnToaVaPhong.Image")));
            this.btnToaVaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToaVaPhong.Location = new System.Drawing.Point(0, 379);
            this.btnToaVaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToaVaPhong.Name = "btnToaVaPhong";
            this.btnToaVaPhong.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnToaVaPhong.Size = new System.Drawing.Size(292, 55);
            this.btnToaVaPhong.TabIndex = 5;
            this.btnToaVaPhong.Text = "Tòa và phòng";
            this.btnToaVaPhong.UseVisualStyleBackColor = false;
            this.btnToaVaPhong.Click += new System.EventHandler(this.btnToaVaPhong_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.AutoScrollMargin = new System.Drawing.Size(2, 0);
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.panelSideMenu.Controls.Add(this.btnDangXuat);
            this.panelSideMenu.Controls.Add(this.btnDoiMatKhau);
            this.panelSideMenu.Controls.Add(this.btnDichVuSuDung);
            this.panelSideMenu.Controls.Add(this.pnlToaPhongSubMenu);
            this.panelSideMenu.Controls.Add(this.btnToaVaPhong);
            this.panelSideMenu.Controls.Add(this.pnlTuyChonSubMenu);
            this.panelSideMenu.Controls.Add(this.btnTuyChon);
            this.panelSideMenu.Controls.Add(this.panelTime);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(313, 683);
            this.panelSideMenu.TabIndex = 2;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 683);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kí Túc Xá";
            this.panelTime.ResumeLayout(false);
            this.pnlTuyChonSubMenu.ResumeLayout(false);
            this.pnlToaPhongSubMenu.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Button btnTuyChon;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Panel pnlTuyChonSubMenu;
        private System.Windows.Forms.Button btnQLHopDong;
        private System.Windows.Forms.Button btnQLTaiKhoan;
        private System.Windows.Forms.Button btnQLSinhVien;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnQLPhong;
        private System.Windows.Forms.Button btnQLToa;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnDichVuSuDung;
        private System.Windows.Forms.Panel pnlToaPhongSubMenu;
        private System.Windows.Forms.Button btnToaVaPhong;
        private System.Windows.Forms.Panel panelSideMenu;
    }
}