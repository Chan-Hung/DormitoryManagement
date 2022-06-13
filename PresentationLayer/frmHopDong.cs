using System;
using System.Windows.Forms;

namespace DormitoryManagement.PresentationLayer
{
    public partial class frmHopDong : Form
    {
        BusinessLogicLayer.BLL_HopDong bll = new BusinessLogicLayer.BLL_HopDong();
        DormitoryContext dbs = new DormitoryContext();

        public frmHopDong()
        {
            InitializeComponent();
        }
        private void ClearBox()
        {
            txtMaHD.Clear();
            txtMaSV.Clear();
            dtpNgayky.Value = DateTime.Now;
            dtpNgayketthuc.Value = DateTime.Now;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            //Tắt nút Thêm/ Sửa/ Xóa
            btnSua.Enabled = false;

            //Vô hiệu hóa trường textbox Mã hợp đồng
            txtMaHD.Enabled = false;
            txtMaSV.Enabled = false;
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            dgvHopDong.DataSource = bll.SelectHopDong();
            dgvHopDong.Columns[4].Visible = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnSua.Enabled = true;
            
            txtMaHD.Enabled = true;
            txtMaSV.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmHopDong_Load(sender, e);
            ClearBox();
        }

        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMaHD.Text = dgvHopDong.Rows[vitri].Cells[0].Value.ToString();
                txtMaSV.Text = dgvHopDong.Rows[vitri].Cells[1].Value.ToString();
            }

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Bật các nút Thêm/ Sửa/ Xóa
            btnSua.Enabled = true;

            //Bật txtMaHD
            txtMaHD.Enabled = true;
            txtMaSV.Enabled = true;

            //Tắt các nút Lưu/ Hủy/
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hợp đồng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã sinh viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string err = "";

            using (var transaction = dbs.Database.BeginTransaction())
            {
                try
                {
                    
                    //Nút sửa được chọn (thao tác Update)
                    if (!bll.UpdateHopDong(ref err, txtMaHD.Text, txtMaSV.Text, dtpNgayky.Value, dtpNgayketthuc.Value))
                        MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
