using System;
using System.Windows.Forms;

namespace DormitoryManagement.PresentationLayer
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            pnlToaPhongSubMenu.Visible = false;
            pnlTuyChonSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (pnlToaPhongSubMenu.Visible == true)
                pnlToaPhongSubMenu.Visible = false;
            if (pnlTuyChonSubMenu.Visible == true)
                pnlTuyChonSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnTuyChon_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlTuyChonSubMenu);
        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClockLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnToaVaPhong_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlToaPhongSubMenu);
        }

        private void btnQLSinhVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSinhVien());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            DateLabel.Text = DateTime.Now.ToString("ddd, d MMMM yyyy");
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTaiKhoan());
        }

        private void btnQLHopDong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHopDong());
        }

        private void btnQLToa_Click(object sender, EventArgs e)
        {
            openChildForm(new frmToa());
        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhong());
        }

        private void btnDichVuSuDung_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTienDien());
            hideSubMenu();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMatKhau());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin dangNhap = new frmLogin();
            this.Hide();
            dangNhap.ShowDialog();
            this.Close();
        }
    }
}
