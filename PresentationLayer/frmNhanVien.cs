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
    public partial class frmNhanVien : Form
    {
        BusinessLogicLayer.BLL_NhanVien bll = new BusinessLogicLayer.BLL_NhanVien();

        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanvien.DataSource = bll.SelectNhanVien();
            dgvNhanvien.Columns[6].Visible = false;
            dgvNhanvien.Columns[7].Visible = false;
            dgvNhanvien.Columns[8].Visible = false;
        }
        private void ClearBox()
        {
            txtMaNV.Clear();
            cbMaLoaiNV.Text = "";
            txtMaToa.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtLuong.Text = "0";
            txtTimkiem.Clear();
            rbSearchTenNV.Checked = false;
            rbSearchMaNV.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.InsertNhanVien(ref err, txtMaNV.Text, cbMaLoaiNV.Text, txtMaToa.Text, txtTenNV.Text, txtSDT.Text, Convert.ToInt32(txtLuong.Text)))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã nhân viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearBox();
                }
                else
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                btnRefresh_Click(sender, e);
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBox();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.UpdateNhanVien(ref err, txtMaNV.Text, cbMaLoaiNV.Text, txtMaToa.Text, txtTenNV.Text, txtSDT.Text, Convert.ToInt32(txtLuong.Text)))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã nhân viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            ClearBox();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMaNV.Text = dgvNhanvien.Rows[vitri].Cells[0].Value.ToString();
                cbMaLoaiNV.Text = dgvNhanvien.Rows[vitri].Cells[1].Value.ToString();
                txtMaToa.Text = dgvNhanvien.Rows[vitri].Cells[2].Value.ToString();
                txtTenNV.Text = dgvNhanvien.Rows[vitri].Cells[3].Value.ToString();
                txtSDT.Text = dgvNhanvien.Rows[vitri].Cells[4].Value.ToString();
                txtLuong.Text = dgvNhanvien.Rows[vitri].Cells[5].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                string err = "";
                if (!bll.DeleteNhanVien(ref err, txtMaNV.Text))
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
