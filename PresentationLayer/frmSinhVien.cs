using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DormitoryManagement.PresentationLayer
{
    public partial class frmSinhVien : Form
    {
        BusinessLogicLayer.BLL_SinhVien bll = new BusinessLogicLayer.BLL_SinhVien();

        BusinessLogicLayer.BLL_HopDong bllhd = new BusinessLogicLayer.BLL_HopDong();

        bool them = true;
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

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
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
            them = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMasv.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMasv.Enabled = false;
            txtTensv.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                string err = "";
                if (!bll.DeleteSinhVien(ref err, txtMasv.Text))
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập trường tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbSearchMaSV.Checked)
            {
                dgvSinhvien.DataSource = bll.searchMaSinhVien(txtTimkiem.Text);
            }
            else if (rbSearchTenSV.Checked)
            {
                dgvSinhvien.DataSource = bll.searchTenSinhVien(txtTimkiem.Text);
            }
            else if (rbSearchToa.Checked)
            {
                dgvSinhvien.DataSource = bll.searchTenToa(txtTimkiem.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnTien_Click(object sender, EventArgs e)
        {
            dgvSinhvien.DataSource = bll.tienPhongCuaSV();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";

            if (them)
            {

                if (bll.chiaToaNamNu(cbGioitinh.Text, txtMaPhong.Text))
                {
                    if (!bll.InsertSinhVien(ref err, txtMasv.Text, txtTensv.Text, cbGioitinh.Text, txtSDT.Text, txtMaTruong.Text, txtMaPhong.Text))
                        if (err.Contains("PRIMARY KEY"))
                        {
                            MessageBox.Show("Mã sinh viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearBox();
                        }
                        else
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Insert Hop Dong
                        int tongSV = bll.countSinhVien();
                        string maHD;
                        if (tongSV < 10)
                            maHD = $"000{tongSV}";
                        else if (tongSV <= 99)
                            maHD = $"00{tongSV}";
                        else maHD = $"0{tongSV}";
                        if (!bllhd.InsertHopDong(ref err, maHD, txtMasv.Text, DateTime.Now, DateTime.Now.AddYears(1)))
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên không được ở tòa khác giới", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnRefresh_Click(sender, e);

            }
            else
            {
                if (!bll.UpdateSinhVien(ref err, txtMasv.Text, txtTensv.Text, cbGioitinh.Text, txtSDT.Text, txtMaTruong.Text, txtMaPhong.Text))
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

                    MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
    }
}