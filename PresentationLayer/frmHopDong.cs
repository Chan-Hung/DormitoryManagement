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
    public partial class frmHopDong : Form
    {
        BusinessLogicLayer.BLL_HopDong bll = new BusinessLogicLayer.BLL_HopDong();
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
            string err = "";
            if (!bll.UpdateHopDong(ref err, txtMaHD.Text, txtMaSV.Text, dtpNgayky.Value, dtpNgayketthuc.Value))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã hợp đồng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            dgvHopDong.DataSource = bll.SelectHopDong();
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
    }
}
