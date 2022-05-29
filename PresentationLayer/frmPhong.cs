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
    public partial class frmPhong : Form
    {
        BusinessLogicLayer.BLL_Phong bll = new BusinessLogicLayer.BLL_Phong();
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            dgvPhong.DataSource = bll.SelectPhong();
            cbTrangThai.Text = "Còn";
            //dgvPhong.Columns[4].Visible = false;
            //dgvPhong.Columns[5].Visible = false;
            //dgvPhong.Columns[6].Visible = false;
            //dgvPhong.Columns[7].Visible = false;
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
            string err = "";
            if (!bll.InsertPhong(ref err, txtMaPhong.Text, txtMaToa.Text, cbMaLoaiPhong.Text, cbTrangThai.Text))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã phòng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!bll.UpdatePhong(ref err, txtMaPhong.Text, txtMaToa.Text, cbMaLoaiPhong.Text, cbTrangThai.Text))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã phòng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
