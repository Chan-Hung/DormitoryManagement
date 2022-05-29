
namespace DormitoryManagement.PresentationLayer
{
    partial class frmToa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToa));
            this.dgvToa = new System.Windows.Forms.DataGridView();
            this.matoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.succhua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sophongtoida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSucChua = new System.Windows.Forms.TextBox();
            this.txtsptd = new System.Windows.Forms.TextBox();
            this.lblSoPhongToiDa = new System.Windows.Forms.Label();
            this.txtSoTang = new System.Windows.Forms.TextBox();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.lblSoTang = new System.Windows.Forms.Label();
            this.lblMaToa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvToa
            // 
            this.dgvToa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matoa,
            this.sotang,
            this.succhua,
            this.sophongtoida});
            this.dgvToa.Location = new System.Drawing.Point(339, 151);
            this.dgvToa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvToa.Name = "dgvToa";
            this.dgvToa.RowHeadersWidth = 51;
            this.dgvToa.Size = new System.Drawing.Size(627, 383);
            this.dgvToa.TabIndex = 61;
            this.dgvToa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToa_CellClick);
            // 
            // matoa
            // 
            this.matoa.DataPropertyName = "matoa";
            this.matoa.HeaderText = "Mã tòa";
            this.matoa.MinimumWidth = 6;
            this.matoa.Name = "matoa";
            this.matoa.Width = 70;
            // 
            // sotang
            // 
            this.sotang.DataPropertyName = "sotang";
            this.sotang.HeaderText = "Số tầng";
            this.sotang.MinimumWidth = 6;
            this.sotang.Name = "sotang";
            this.sotang.Width = 110;
            // 
            // succhua
            // 
            this.succhua.DataPropertyName = "succhua";
            this.succhua.HeaderText = "Sức chứa";
            this.succhua.MinimumWidth = 6;
            this.succhua.Name = "succhua";
            this.succhua.Width = 110;
            // 
            // sophongtoida
            // 
            this.sophongtoida.DataPropertyName = "sophongtoida";
            this.sophongtoida.HeaderText = "Số phòng tối đa";
            this.sophongtoida.MinimumWidth = 6;
            this.sophongtoida.Name = "sophongtoida";
            this.sophongtoida.Width = 120;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(553, 69);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnRefresh.Size = new System.Drawing.Size(80, 74);
            this.btnRefresh.TabIndex = 66;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(449, 69);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnSua.Size = new System.Drawing.Size(80, 74);
            this.btnSua.TabIndex = 55;
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
            this.btnThem.Location = new System.Drawing.Point(339, 69);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnThem.Size = new System.Drawing.Size(80, 74);
            this.btnThem.TabIndex = 56;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(159, 320);
            this.txtSucChua.Margin = new System.Windows.Forms.Padding(4);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(159, 22);
            this.txtSucChua.TabIndex = 59;
            this.txtSucChua.Text = "0";
            // 
            // txtsptd
            // 
            this.txtsptd.Location = new System.Drawing.Point(159, 404);
            this.txtsptd.Margin = new System.Windows.Forms.Padding(4);
            this.txtsptd.Name = "txtsptd";
            this.txtsptd.Size = new System.Drawing.Size(159, 22);
            this.txtsptd.TabIndex = 60;
            this.txtsptd.Text = "0";
            // 
            // lblSoPhongToiDa
            // 
            this.lblSoPhongToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhongToiDa.Location = new System.Drawing.Point(13, 404);
            this.lblSoPhongToiDa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoPhongToiDa.Name = "lblSoPhongToiDa";
            this.lblSoPhongToiDa.Size = new System.Drawing.Size(130, 18);
            this.lblSoPhongToiDa.TabIndex = 65;
            this.lblSoPhongToiDa.Text = "Số phòng tối đa";
            // 
            // txtSoTang
            // 
            this.txtSoTang.Location = new System.Drawing.Point(159, 236);
            this.txtSoTang.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTang.Name = "txtSoTang";
            this.txtSoTang.Size = new System.Drawing.Size(159, 22);
            this.txtSoTang.TabIndex = 58;
            this.txtSoTang.Text = "0";
            // 
            // txtMaToa
            // 
            this.txtMaToa.Location = new System.Drawing.Point(159, 151);
            this.txtMaToa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaToa.Name = "txtMaToa";
            this.txtMaToa.Size = new System.Drawing.Size(159, 22);
            this.txtMaToa.TabIndex = 57;
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucChua.Location = new System.Drawing.Point(46, 320);
            this.lblSucChua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(70, 18);
            this.lblSucChua.TabIndex = 64;
            this.lblSucChua.Text = "Sức chứa";
            // 
            // lblSoTang
            // 
            this.lblSoTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTang.Location = new System.Drawing.Point(56, 237);
            this.lblSoTang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoTang.Name = "lblSoTang";
            this.lblSoTang.Size = new System.Drawing.Size(70, 22);
            this.lblSoTang.TabIndex = 63;
            this.lblSoTang.Text = "Số tầng";
            // 
            // lblMaToa
            // 
            this.lblMaToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaToa.Location = new System.Drawing.Point(56, 152);
            this.lblMaToa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaToa.Name = "lblMaToa";
            this.lblMaToa.Size = new System.Drawing.Size(60, 21);
            this.lblMaToa.TabIndex = 62;
            this.lblMaToa.Text = "Mã tòa";
            // 
            // frmToa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 603);
            this.Controls.Add(this.dgvToa);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSucChua);
            this.Controls.Add(this.txtsptd);
            this.Controls.Add(this.lblSoPhongToiDa);
            this.Controls.Add(this.txtSoTang);
            this.Controls.Add(this.txtMaToa);
            this.Controls.Add(this.lblSucChua);
            this.Controls.Add(this.lblSoTang);
            this.Controls.Add(this.lblMaToa);
            this.Name = "frmToa";
            this.Text = "frmToa";
            this.Load += new System.EventHandler(this.frmToa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn matoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotang;
        private System.Windows.Forms.DataGridViewTextBoxColumn succhua;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophongtoida;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.TextBox txtsptd;
        private System.Windows.Forms.Label lblSoPhongToiDa;
        private System.Windows.Forms.TextBox txtSoTang;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.Label lblSoTang;
        private System.Windows.Forms.Label lblMaToa;
    }
}