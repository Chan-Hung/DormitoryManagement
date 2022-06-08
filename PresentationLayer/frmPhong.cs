using System;
using System.Windows.Forms;

namespace DormitoryManagement.PresentationLayer
{
    public partial class frmPhong : Form
    {
        BusinessLogicLayer.BLL_Phong bll = new BusinessLogicLayer.BLL_Phong();
        DormitoryContext dbs = new DormitoryContext();
        bool them = true;
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            dgvPhong.DataSource = bll.SelectPhong();
            cbTrangThai.Text = "Còn";
            dgvPhong.Columns[4].Visible = false;
            dgvPhong.Columns[5].Visible = false;
            dgvPhong.Columns[6].Visible = false;
            dgvPhong.Columns[7].Visible = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnPhongTrong.Enabled = true;

            //Bật txtMaPhong
            txtMaPhong.Enabled = true;
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMaPhong.Text = dgvPhong.Rows[vitri].Cells[0].Value.ToString();
                cbMaLoaiPhong.Text = dgvPhong.Rows[vitri].Cells[2].Value.ToString();
                txtMaToa.Text = dgvPhong.Rows[vitri].Cells[1].Value.ToString();
                cbTrangThai.Text = dgvPhong.Rows[vitri].Cells[3].Value.ToString();
            }
        }
        private void ClearBox()
        {
            txtMaPhong.Clear();
            txtMaToa.Clear();
            cbMaLoaiPhong.Text = "";
            cbTrangThai.Text = "Còn";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmPhong_Load(sender, e);
            ClearBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnPhongTrong.Enabled = false;

            txtMaPhong.Focus();
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
            btnPhongTrong.Enabled = false;

            //Vô hiệu hóa trường textbox Mã phòng
            txtMaPhong.Enabled = false;
            cbMaLoaiPhong.Focus();
        }

        private void btnPhongTrong_Click(object sender, EventArgs e)
        {
            dgvPhong.DataSource = bll.ShowPhongTrong();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Bật các nút Thêm/ Sửa/ Xóa
            btnThem.Enabled = true;
            btnSua.Enabled = true;

            //Bật txtMaPhong
            txtMaPhong.Enabled = true;
            //Bật nút phòng trống
            btnPhongTrong.Enabled = true;

            //Tắt các nút Lưu/ Hủy/
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra nhập đủ các trường not null
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbMaLoaiPhong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã loại phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (them)
                    {
                        //Kiểm tra phòng có tồn tại hay chưa
                        if (!bll.checkMaPhong(txtMaPhong.Text))
                        {
                            MessageBox.Show("Phòng đã tồn tại, vui lòng nhập mã phòng khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (!bll.InsertPhong(ref err, txtMaPhong.Text, cbMaLoaiPhong.Text, txtMaToa.Text, cbTrangThai.Text))
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Nút sửa được chọn (thao tác Update)
                    else
                    {
                        if (!bll.UpdatePhong(ref err, txtMaPhong.Text, cbMaLoaiPhong.Text, txtMaToa.Text, cbTrangThai.Text))
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
