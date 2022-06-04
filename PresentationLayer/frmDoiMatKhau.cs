using System;
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
            
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            txtMatkhaucu.Text = "";
            txtMatkhaumoi.Text = "";
            txtXacnhan.Text = "";
        }
    }
}
