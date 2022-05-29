using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagement.PresentationLayer
{
    public partial class frmTienDien : Form
    {
        BusinessLogicLayer.BLL_DienNuoc bll = new BusinessLogicLayer.BLL_DienNuoc();
        public frmTienDien()
        {
            InitializeComponent();
        }

        private void frmTienDien_Load(object sender, EventArgs e)
        {
            //dgvSoDienTieuThu.DataSource = bll.SelectDienNuoc();
            //dgvSoDienTieuThu.Columns[6].Visible = false;
            //dgvSoDienTieuThu.Columns[6] = dgvSoDienTieuThu.Columns[6];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.insertDienNuoc(ref err, txtMaHoaDon.Text, txtMaPhong.Text, dtpNgaylap.Value, Convert.ToInt32(txtSoDienTieuThu.Text), Convert.ToInt32(txtSoNuocTieuThu.Text), cbTrangThai.Text))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã hóa đơn không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearBox();
                }
                else
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                btnRefresh_Click(sender, e);
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ClearBox()
        {
            txtMaHoaDon.Clear();
            txtMaPhong.Clear();
            txtSoDienTieuThu.Clear();
            txtSoNuocTieuThu.Clear();
            dtpNgaylap.Value = DateTime.Now;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmTienDien_Load(sender, e);
            ClearBox();
        }
    }
}
