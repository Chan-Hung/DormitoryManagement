using System.Linq;

namespace DormitoryManagement.BusinessLogicLayer
{
    class BLL_Login
    {
        QuanLyKTXModel dbs = new QuanLyKTXModel();
        public bool AuthLogin(string username, string password)
        {
            bool flag = false;
            var toAuth = (from e in dbs.TaiKhoans
                          where e.TenDangNhap == username && e.MatKhau == password
                          select e).FirstOrDefault();
            if (toAuth != null)
            {
                Global.account_ID = toAuth.MaTaiKhoan;
                Global.account_role = toAuth.MaLoaiTaiKhoan;
                flag = true;
            }
            return flag;
        }
    }
}
