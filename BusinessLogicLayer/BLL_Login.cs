using System.Linq;

namespace DormitoryManagement.BusinessLogicLayer
{
    class BLL_Login
    {
        DormitoryContext dbs = new DormitoryContext();

        public bool AuthLogin(string username, string password)
        {
            bool flag = false;
            var toAuth = (from e in dbs.TaiKhoans
                          where e.Username == username && e.Password == password
            var toAuth = (from e in dbs.Accounts
                          where e.TenDangNhap == username && e.MatKhau == password
                          select e).FirstOrDefault();
            if (toAuth != null)
            {
                Global.account_ID = toAuth.AccountID;
                Global.account_role = toAuth.AccountTypeID;
                flag = true;
            }
            return flag;
        }
    }
}
