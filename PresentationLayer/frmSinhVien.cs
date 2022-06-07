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
        DormitoryContext dbs = new DormitoryContext();
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

            //Bật txtMaSV
            txtMasv.Enabled = true;
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
            //Tắt cờ them (thao tác Update)
            them = false;

            //Bật nút Lưu/ Hủy
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            //Tắt nút Thêm/ Sửa/ Xóa
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            //Vô hiệu hóa trườn textbox Mã sinh viên
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
            //Kiểm tra nhập đủ các trường
            if (txtMasv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTensv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbGioitinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giới tính", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMaTruong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã trường", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Thông báo lỗi
            string err = "";

            //Kiểm tra full phòng
            if (!bll.checkFullPhong(txtMaPhong.Text))
            {
                MessageBox.Show("Phòng đã đầy, vui lòng chọn phòng khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Kiểm tra sinh viên nam/nữ phải ở tòa danh cho nam/nữ
            if (!bll.checkChiaToaTheoGioiTinh(cbGioitinh.Text, txtMaPhong.Text))
            {
                MessageBox.Show("Sinh viên không được ở tòa khác giới", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Nút thêm được chọn (thao tác Insert)

            using (var transaction = dbs.Database.BeginTransaction())
            {
                try
                {
                    if (them)
                    {
                        //Kiểm tra mã sinh viên không được trùng khi thêm
                        if (!bll.checkMaSinhVien(txtMasv.Text))
                        {
                            MessageBox.Show("Mã sinh viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (!bll.InsertSinhVien(ref err, txtMasv.Text, txtTensv.Text, cbGioitinh.Text, txtSDT.Text, txtMaTruong.Text, txtMaPhong.Text))
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Đổi trạng thái phòng
                            bll.doiTrangThaiPhong(txtMasv.Text, txtMaPhong.Text);

                            //Insert hợp đồng vào table HopDong
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

                    //Nút sửa được chọn (thao tác Update)
                    else
                    {
                        if (!bll.UpdateSinhVien(ref err, txtMasv.Text, txtTensv.Text, cbGioitinh.Text, txtSDT.Text, txtMaTruong.Text, txtMaPhong.Text))
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Bật các nút Thêm/ Sửa/ Xóa
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            //Bật txtMaSv
            txtMasv.Enabled = true;

            //Tắt các nút Lưu/ Hủy
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
    }
}