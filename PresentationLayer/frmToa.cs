using System;
using System.Windows.Forms;

namespace DormitoryManagement.PresentationLayer
{
    public partial class frmToa : Form
    {
        BusinessLogicLayer.BLL_Toa bll = new BusinessLogicLayer.BLL_Toa();
        public frmToa()
        {
            InitializeComponent();
        }

        private void frmToa_Load(object sender, EventArgs e)
        {
            dgvToa.DataSource = bll.SelectToa();
            dgvToa.Columns[4].Visible = false;
            dgvToa.Columns[5].Visible = false;
            
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
            string err = "";
            if (!bll.InsertToa(ref err, txtMaToa.Text, Convert.ToInt16(txtSoTang.Text), Convert.ToInt32(txtSucChua.Text), Convert.ToInt16(txtsptd.Text)))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã tòa không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!bll.UpdateToa(ref err, txtMaToa.Text, Convert.ToInt16(txtSoTang.Text), Convert.ToInt32(txtSucChua.Text), Convert.ToInt16(txtsptd.Text)))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã tòa không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
