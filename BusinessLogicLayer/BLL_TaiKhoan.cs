using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_TaiKhoan
    {
        DormitoryContext dbs = new DormitoryContext();
        
        public List<Account> SelectTaiKhoan()
        {
            return dbs.Accounts.ToList();
        }
        public bool insertTaiKhoan(ref string err, string manv, string tendangnhap, string matkhau, string maloaitaikhoan)
        {
            bool flag = false;
            try
            {
                Account tk = new Account();
                tk.MaNV = manv;
                tk.TenDangNhap = tendangnhap;
                tk.MatKhau = matkhau;
                tk.MaLoaiTaiKhoan = maloaitaikhoan;
                dbs.Accounts.Add(tk);
                dbs.SaveChanges();
                flag = true;
            }
            catch (SqlException)
            {
                err = "Đã xảy ra lỗi";
            }
            return flag;
        }

        public bool updateTaiKhoan(ref string err, string manv, string tendangnhap, string maloaitaikhoan)
        {
            bool flag = false;
            try
            {
                var tk = dbs.Accounts.Where(x=>x.MaNV==manv).FirstOrDefault();
                if (tk != null)
                {
                    tk.MaNV = manv;
                    tk.TenDangNhap = tendangnhap;
                    tk.MaLoaiTaiKhoan = maloaitaikhoan;
                    dbs.SaveChanges();
                    flag = true;
                }
            }
            catch (SqlException)
            {
                err = "Đã xảy ra lỗi";
            }
            return flag;
        }
        public bool deleteTaiKhoan(ref string err, string manv)
        {
            bool flag = false;
            var tk = dbs.Accounts.Where(x => x.MaNV == manv).FirstOrDefault();
            if (tk != null)
            {
                dbs.Accounts.Remove(tk);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }

    }
}
