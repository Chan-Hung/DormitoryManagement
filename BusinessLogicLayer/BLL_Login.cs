using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.BusinessLogicLayer
{
    class BLL_Login
    {
        QuanLyKTXModel dbs = new QuanLyKTXModel();

        public bool AuthLogin(string username, string password)
        {
            bool flag = false;
            var toAuth = dbs.TaiKhoans.Find(username);
            if(toAuth != null)
            {
                if (password.Equals(toAuth.MatKhau)) //if (password == toAuth.MatKhau)
                    flag = true;
            }
            return flag;
        }
    }
}
