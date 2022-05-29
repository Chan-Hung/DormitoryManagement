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
    public partial class frmLogin : Form
    {
        BusinessLogicLayer.BLL_Login bll = new BusinessLogicLayer.BLL_Login();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(bll.AuthLogin(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDashboard dashBoard = new frmDashboard();
                this.Hide();
                dashBoard.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
