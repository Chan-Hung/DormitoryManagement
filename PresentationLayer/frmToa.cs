using System;
using System.Windows.Forms;

namespace DormitoryManagement.PresentationLayer
{
    public partial class frmToa : Form
    {
        BusinessLogicLayer.BLL_Toa bll = new BusinessLogicLayer.BLL_Toa();
        DormitoryContext dbs = new DormitoryContext();
        bool them = true;
        public frmToa()
        {
            InitializeComponent();
        }

        private void frmToa_Load(object sender, EventArgs e)
        {
            dgvToa.DataSource = bll.SelectToa();
            dgvToa.Columns[4].Visible = false;
            dgvToa.Columns[5].Visible = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;

            //Bật txtMaToa
            txtMaToa.Enabled = true;

        }
        private void ClearBox()
        {
            txtMaToa.Clear();
            txtSoTang.Text = "0";
            txtsptd.Text = "0";
            txtSucChua.Text = "0";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmToa_Load(sender, e);
            ClearBox();
        }

        private void dgvToa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMaToa.Text = dgvToa.Rows[vitri].Cells[0].Value.ToString();
                txtSoTang.Text = dgvToa.Rows[vitri].Cells[1].Value.ToString();
                txtSucChua.Text = dgvToa.Rows[vitri].Cells[2].Value.ToString();
                txtsptd.Text = dgvToa.Rows[vitri].Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;

            txtMaToa.Focus();
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

            //Vô hiệu hóa trườn textbox Mã tòa
            txtMaToa.Enabled = false;
            txtSoTang.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Bật các nút Thêm/ Sửa/ Xóa
            btnThem.Enabled = true;
            btnSua.Enabled = true;

            //Bật txtMaToa
            txtMaToa.Enabled = true;

            //Tắt các nút Lưu/ Hủy
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra nhập đủ các trường
            if (txtMaToa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã tòa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtSoTang.Text == "0")
            {
                MessageBox.Show("Vui lòng nhập số tầng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtSucChua.Text == "0")
            {
                MessageBox.Show("Vui lòng nhập sức chứa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtsptd.Text == "0")
            {
                MessageBox.Show("Vui lòng nhập số phòng tối đa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        if (!bll.checkMaToa(txtMaToa.Text))
                        {
                            MessageBox.Show("Mã tòa đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (!bll.InsertToa(ref err, txtMaToa.Text, short.Parse(txtSoTang.Text), short.Parse(txtSucChua.Text), short.Parse(txtsptd.Text)))
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Nút sửa được chọn (thao tác Update)
                    else
                    {
                        if (!bll.UpdateToa(ref err, txtMaToa.Text, short.Parse(txtSoTang.Text), short.Parse(txtSucChua.Text), short.Parse(txtsptd.Text)))
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
