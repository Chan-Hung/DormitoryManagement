using System;
using System.Windows.Forms;

namespace DormitoryManagement.PresentationLayer
{
    public partial class frmNhanVien : Form
    {
        BusinessLogicLayer.BLL_NhanVien bll = new BusinessLogicLayer.BLL_NhanVien();
        DormitoryContext dbs = new DormitoryContext();
        bool them = true;
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

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            //Bật txtMaNV
            txtMaNV.Enabled = true;
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
            //rbSearchToa.Checked = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaNV.Focus();
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
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            //Vô hiệu hóa trường textbox Mã nhân viên
            txtMaNV.Enabled = false;
            txtTenNV.Focus();
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập trường tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbSearchMaNV.Checked)
            {
                dgvNhanvien.DataSource = bll.searchMaNhanVien(txtTimkiem.Text);
            }
            else if (rbSearchTenNV.Checked)
            {
                dgvNhanvien.DataSource = bll.searchTenNhanVien(txtTimkiem.Text);
            }
            else if (rbSearchToa.Checked)
            {
                dgvNhanvien.DataSource = bll.searchMaToa(txtTimkiem.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Bật các nút Thêm/ Sửa/ Xóa
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            //Bật txtMaNV
            txtMaNV.Enabled = true;

            //Tắt các nút Lưu/ Hủy
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra nhập đủ các trường not null
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbMaLoaiNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã loại nhân viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMaToa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã tòa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Thông báo lỗi
            string err = "";
            using (var transaction = dbs.Database.BeginTransaction())
            {
                try
                {
                    //Nút thêm được chọn (thao tác Insert)
                    if (them)
                    {
                        //Kiểm tra mã nhân viên đúng định dạng
                        if (!bll.checkDinhDangMaNV(txtMaNV.Text, cbMaLoaiNV.Text))
                        {
                            MessageBox.Show("Mã nhân viên hoặc mã loại nhân viên không đúng định dạng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //Kiểm tra mã nhân viên không được trùng
                        else if (!bll.checkMaNhanVien(txtMaNV.Text))
                        {
                            MessageBox.Show("Mã nhân viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (!bll.InsertNhanVien(ref err, txtMaNV.Text, cbMaLoaiNV.Text, txtMaToa.Text, txtTenNV.Text, txtSDT.Text, int.Parse(txtLuong.Text)))
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Nút sửa được chọn (thao tác Update)
                    else
                    {
                        if (!bll.UpdateNhanVien(ref err, txtMaNV.Text, cbMaLoaiNV.Text, txtMaToa.Text, txtTenNV.Text, txtSDT.Text, int.Parse(txtLuong.Text)))
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
