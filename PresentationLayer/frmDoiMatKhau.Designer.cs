
namespace DormitoryManagement.PresentationLayer
{
    partial class frmDoiMatKhau
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
            this.btnHuybo = new System.Windows.Forms.Button();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.txtMatkhaucu = new System.Windows.Forms.TextBox();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtXacnhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuybo
            // 
            this.btnHuybo.BackColor = System.Drawing.Color.IndianRed;
            this.btnHuybo.FlatAppearance.BorderSize = 0;
            this.btnHuybo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuybo.ForeColor = System.Drawing.Color.White;
            this.btnHuybo.Location = new System.Drawing.Point(422, 289);
            this.btnHuybo.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(107, 31);
            this.btnHuybo.TabIndex = 17;
            this.btnHuybo.Text = "Hủy bỏ";
            this.btnHuybo.UseVisualStyleBackColor = false;
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.Color.SpringGreen;
            this.btnXacnhan.FlatAppearance.BorderSize = 0;
            this.btnXacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacnhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacnhan.Location = new System.Drawing.Point(263, 289);
            this.btnXacnhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(107, 31);
            this.btnXacnhan.TabIndex = 18;
            this.btnXacnhan.Text = "Đổi mật khẩu";
            this.btnXacnhan.UseVisualStyleBackColor = false;
            // 
            // txtMatkhaucu
            // 
            this.txtMatkhaucu.Location = new System.Drawing.Point(384, 131);
            this.txtMatkhaucu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatkhaucu.Name = "txtMatkhaucu";
            this.txtMatkhaucu.Size = new System.Drawing.Size(196, 22);
            this.txtMatkhaucu.TabIndex = 14;
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Location = new System.Drawing.Point(384, 183);
            this.txtMatkhaumoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.Size = new System.Drawing.Size(196, 22);
            this.txtMatkhaumoi.TabIndex = 15;
            // 
            // txtXacnhan
            // 
            this.txtXacnhan.Location = new System.Drawing.Point(384, 235);
            this.txtXacnhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtXacnhan.Name = "txtXacnhan";
            this.txtXacnhan.Size = new System.Drawing.Size(196, 22);
            this.txtXacnhan.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Xác nhận mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mật khẩu mới";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 603);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.txtMatkhaucu);
            this.Controls.Add(this.txtMatkhaumoi);
            this.Controls.Add(this.txtXacnhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiMatKhau";
            this.Text = "frmDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.TextBox txtMatkhaucu;
        private System.Windows.Forms.TextBox txtMatkhaumoi;
        private System.Windows.Forms.TextBox txtXacnhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}