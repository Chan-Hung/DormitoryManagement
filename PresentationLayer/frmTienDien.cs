using System;
using System.Windows.Forms;

namespace DormitoryManagement.PresentationLayer
{
    public partial class frmTienDien : Form
    {
        BusinessLogicLayer.BLL_TienDien bll = new BusinessLogicLayer.BLL_TienDien();
        DormitoryContext dbs = new DormitoryContext();
        bool them = true;
        public frmTienDien()
        {
            InitializeComponent();
        }

        private void frmTienDien_Load(object sender, EventArgs e)
        {
            dgvSoDienTieuThu.DataSource = bll.SelectTienDien();
            dgvSoDienTieuThu.Columns[6].Visible = false;
            //dgvSoDienTieuThu.Columns[6] = dgvSoDienTieuThu.Columns[6];

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThanhToan.Enabled = true;
            btnPhongChuaThanhToan.Enabled = true;

            //Bật txtMaHoaDon
            txtMaHoaDon.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThanhToan.Enabled = false;
            btnPhongChuaThanhToan.Enabled = false;

            txtMaHoaDon.Focus();
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
            //Tắt cờ them (thao tác Update)
            them = false;

            //Bật nút Lưu/ Hủy
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            //Tắt nút Thêm/ Sửa/ Xóa/ Thanh toán/ Hiển thị phòng
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThanhToan.Enabled = false;
            btnPhongChuaThanhToan.Enabled = false;

            //Vô hiệu hóa trường textbox Mã hóa đơn
            txtMaHoaDon.Enabled = false;
            txtMaPhong.Focus();
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

        private void btnPhongChuaThanhToan_Click(object sender, EventArgs e)
        {
            dgvSoDienTieuThu.DataSource = bll.SelectChuaThanhToan();
        }

        private void dgvSoDienTieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMaHoaDon.Text = dgvSoDienTieuThu.Rows[vitri].Cells[0].Value.ToString();
                txtMaPhong.Text = dgvSoDienTieuThu.Rows[vitri].Cells[1].Value.ToString();
                txtSoDienTieuThu.Text = dgvSoDienTieuThu.Rows[vitri].Cells[3].Value.ToString();
                txtSoNuocTieuThu.Text = dgvSoDienTieuThu.Rows[vitri].Cells[4].Value.ToString();
                cbTrangThai.Text = dgvSoDienTieuThu.Rows[vitri].Cells[5].Value.ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string err = "";
            if (bll.ThanhToan(ref err, txtMaHoaDon.Text))
            {
                MessageBox.Show("Phòng " + txtMaPhong.Text.ToString() + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefresh_Click(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Bật các nút Thêm/ Sửa/ Xóa
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThanhToan.Enabled = true;
            btnPhongChuaThanhToan.Enabled = true;

            //Bật txtMaHoaDon
            txtMaHoaDon.Enabled = true;

            //Tắt các nút Lưu/ Hủy
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra nhập đủ các trường
            if (txtMaHoaDon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtSoDienTieuThu.Text == "0")
            {
                MessageBox.Show("Vui lòng nhập số điện tiêu thụ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtSoNuocTieuThu.Text == "0")
            {
                MessageBox.Show("Vui lòng nhập số nước tiêu thụ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Thông báo lỗi
            string err = "";

            //Nút thêm được chọn (thao tác Insert)

            using (var transaction = dbs.Database.BeginTransaction())
            {
                try
                {
                    if (them)
                    {
                        //Kiểm tra mã hóa đơn không được trùng khi thêm
                        if (!bll.checkMaHoaDon(txtMaHoaDon.Text))
                        {
                            MessageBox.Show("Mã hóa đơn không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (!bll.InsertTienDien(ref err, txtMaHoaDon.Text, txtMaPhong.Text, DateTime.Parse(dtpNgaylap.Text), int.Parse(txtSoDienTieuThu.Text), int.Parse(txtSoNuocTieuThu.Text), cbTrangThai.Text))
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Nút sửa được chọn (thao tác Update)
                    else
                    {
                        if (!bll.UpdateTienDien(ref err, txtMaHoaDon.Text, txtMaPhong.Text, DateTime.Parse(dtpNgaylap.Text), int.Parse(txtSoDienTieuThu.Text), int.Parse(txtSoNuocTieuThu.Text), cbTrangThai.Text))
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
        //Thêm trigger ngày kết thúc > ngày đăng ký
    }
}
