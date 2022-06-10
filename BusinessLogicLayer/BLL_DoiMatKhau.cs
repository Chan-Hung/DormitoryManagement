using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace DormitoryManagement.BusinessLogicLayer
{
    class BLL_DoiMatKhau
    {
        DormitoryContext dbs = new DormitoryContext();
        public bool ChangePassword(ref string err, int id, string oldPassword, string newPassword, string confirmation)
        {
            bool flag = false;
            try
            {
                var taikhoan = dbs.TaiKhoans.Find(id);
                if(taikhoan.Password == oldPassword)
                var taikhoan = dbs.Accounts.Find(id);
                if(taikhoan.MatKhau == oldPassword)
                {
                    if(newPassword == confirmation)
                    {
                        taikhoan.Password = newPassword;
                        flag = true;
                        dbs.SaveChanges();
                    }
                    else
                    {
                        err = "Xác nhận mật khẩu mới không đúng!";
                    }
                }
                else
                {
                    err = "Mật khẩu cũ không đúng";
                }
            }
            catch (SqlException)
            {
                err = "Loi roi thay oi";
            }
            return flag;
        }
    }
}
