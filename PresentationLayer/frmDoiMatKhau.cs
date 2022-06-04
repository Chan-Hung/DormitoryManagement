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
    public partial class frmDoiMatKhau : Form
    {
        BusinessLogicLayer.BLL_DoiMatKhau bll = new BusinessLogicLayer.BLL_DoiMatKhau();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.ChangePassword(ref err, Global.account_ID, txtMatkhaucu.Text, txtMatkhaumoi.Text, txtXacnhan.Text))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnHuybo_Click(sender, e);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            txtMatkhaucu.Text = "";
            txtMatkhaumoi.Text = "";
            txtXacnhan.Text = "";
        }
    }
}
