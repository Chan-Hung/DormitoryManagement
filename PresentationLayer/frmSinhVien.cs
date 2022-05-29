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
    public partial class frmSinhVien : Form
    {
        BusinessLogicLayer.BLL_SinhVien bll = new BusinessLogicLayer.BLL_SinhVien();
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            dgvSinhvien.DataSource = bll.SelectSinhVien();
            dgvSinhvien.Columns[6].Visible = false;
            dgvSinhvien.Columns[7].Visible = false;
            dgvSinhvien.Columns[8].Visible = false;
        }

        private void dgvSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMasv.Text = dgvSinhvien.Rows[vitri].Cells[0].Value.ToString();
                txtTensv.Text = dgvSinhvien.Rows[vitri].Cells[1].Value.ToString();
                cbGioitinh.Text = dgvSinhvien.Rows[vitri].Cells[2].Value.ToString();
                txtSDT.Text = dgvSinhvien.Rows[vitri].Cells[3].Value.ToString();
                txtMaTruong.Text = dgvSinhvien.Rows[vitri].Cells[4].Value.ToString();
                txtMaPhong.Text = dgvSinhvien.Rows[vitri].Cells[5].Value.ToString();
            }
        }
        private void ClearBox()
        {
            txtMasv.Clear();
            txtTensv.Clear();
            cbGioitinh.Text = "";
            txtSDT.Clear();
            txtMaTruong.Clear();
            txtMaPhong.Clear();
            txtTimkiem.Clear();
            rbSearchMaSV.Checked = false;
            rbSearchTenSV.Checked = false;
            rbSearchToa.Checked = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmSinhVien_Load(sender, e);
            ClearBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if(!bll.InsertSinhVien(ref err, txtMasv.Text, txtTensv.Text, cbGioitinh.Text, txtSDT.Text, txtMaTruong.Text, txtMaPhong.Text))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã sinh viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (bll.UpdateSinhVien(ref err, txtMasv.Text, txtTensv.Text, cbGioitinh.Text, txtSDT.Text, txtMaTruong.Text, txtMaPhong.Text)==0)
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã sinh viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearBox();
                }
                else
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //btnRefresh_Click(sender, e);
                frmSinhVien_Load(sender, e);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                string err = "";
                if (bll.DeleteSinhVien(ref err, txtMasv.Text)==0)
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
