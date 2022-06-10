using System;
using System.Windows.Forms;

namespace DormitoryManagement.PresentationLayer
{
    public partial class frmTaiKhoan : Form
    {
        BusinessLogicLayer.BLL_TaiKhoan bll = new BusinessLogicLayer.BLL_TaiKhoan();
        DormitoryContext dbs = new DormitoryContext();
        bool them = true;

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            cbMaLoaiTaiKhoan.Focus();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Tắt cờ them (thao tác Update)
            them = false;

            //Bật nút Lưu/ Hủy
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            //Tắt nút Thêm/ Sửa/ Xóa
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            //Vô hiệu txtMatKhau
            txtMatkhau.Enabled = false;
            txtMaNV.Enabled = false;
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmTaiKhoan_Load(sender, e);
            ClearBox();
        }
        private void ClearBox()
        {
            txtMaNV.Clear();
            txtTenDangNhap.Clear();
            txtMatkhau.Clear();
            cbMaLoaiTaiKhoan.Text = "";
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = bll.SelectTaiKhoan();
            dgvTaiKhoan.Columns[5].Visible = false;
            dgvTaiKhoan.Columns[6].Visible = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            txtMatkhau.Enabled = true;
            txtMaNV.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                string err = "";
                if (!bll.deleteTaiKhoan(ref err, txtMaNV.Text))
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Bật các nút Thêm/ Sửa/ Xóa
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //Tắt các nút Lưu/ Hủy
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //Active txtMatKhau
            txtMatkhau.Enabled = true;
            txtMaNV.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbMaLoaiTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã loại tài khoản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string err = "";
            
            using(var transaction = dbs.Database.BeginTransaction())
            {
                try
                {
                    if (them)
                    {
                        if (!bll.insertTaiKhoan(ref err, txtMaNV.Text, txtTenDangNhap.Text, txtMatkhau.Text, cbMaLoaiTaiKhoan.Text))
                        {

                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {
                            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        
                        if (!bll.updateTaiKhoan(ref err, txtMaNV.Text, txtTenDangNhap.Text, cbMaLoaiTaiKhoan.Text))
                        {

                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {
                            
                            MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    btnRefresh_Click(sender, e);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                cbMaLoaiTaiKhoan.Text = dgvTaiKhoan.Rows[vitri].Cells[4].Value.ToString();
                txtMaNV.Text = dgvTaiKhoan.Rows[vitri].Cells[1].Value.ToString();
                txtTenDangNhap.Text = dgvTaiKhoan.Rows[vitri].Cells[2].Value.ToString();
                txtMatkhau.Text = dgvTaiKhoan.Rows[vitri].Cells[3].Value.ToString();
            }
        }
    }
}
