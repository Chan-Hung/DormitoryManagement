
namespace DormitoryManagement.PresentationLayer
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pbBigImage = new System.Windows.Forms.PictureBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.pbLoginLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBigImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Green;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(58, 349);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(227, 46);
            this.btnDangNhap.TabIndex = 13;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // pbBigImage
            // 
            this.pbBigImage.Image = ((System.Drawing.Image)(resources.GetObject("pbBigImage.Image")));
            this.pbBigImage.Location = new System.Drawing.Point(351, -9);
            this.pbBigImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbBigImage.Name = "pbBigImage";
            this.pbBigImage.Size = new System.Drawing.Size(684, 444);
            this.pbBigImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBigImage.TabIndex = 12;
            this.pbBigImage.TabStop = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(58, 290);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(227, 22);
            this.txtMatKhau.TabIndex = 11;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMatKhau.Location = new System.Drawing.Point(58, 258);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(109, 29);
            this.lblMatKhau.TabIndex = 10;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(58, 222);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(227, 22);
            this.txtTaiKhoan.TabIndex = 9;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTaiKhoan.Location = new System.Drawing.Point(58, 190);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(109, 29);
            this.lblTaiKhoan.TabIndex = 8;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // pbLoginLogo
            // 
            this.pbLoginLogo.BackColor = System.Drawing.SystemColors.Window;
            this.pbLoginLogo.Location = new System.Drawing.Point(65, 25);
            this.pbLoginLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLoginLogo.Name = "pbLoginLogo";
            this.pbLoginLogo.Size = new System.Drawing.Size(220, 162);
            this.pbLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoginLogo.TabIndex = 7;
            this.pbLoginLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 434);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.pbBigImage);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.pbLoginLogo);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbBigImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox pbBigImage;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.PictureBox pbLoginLogo;
    }
}