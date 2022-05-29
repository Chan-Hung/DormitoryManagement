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
        BusinessLogicLayer.BLL_TienDien bll = new BusinessLogicLayer.BLL_TienDien();
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
            if (!bll.InsertTienDien(ref err, txtMaHoaDon.Text, txtMaPhong.Text, dtpNgaylap.Value, Convert.ToInt32(txtSoDienTieuThu.Text), Convert.ToInt32(txtSoNuocTieuThu.Text), cbTrangThai.Text))
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.UpdateTienDien(ref err, txtMaHoaDon.Text, txtMaPhong.Text, dtpNgaylap.Value, Convert.ToInt32(txtSoDienTieuThu.Text), Convert.ToInt32(txtSoNuocTieuThu.Text), cbTrangThai.Text))
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
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                string err = "";
                if (!bll.DeleteTienDien(ref err, txtMaHoaDon.Text))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnRefresh_Click(sender, e);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (dlr == DialogResult.No)
                return;
        }
    }
}
