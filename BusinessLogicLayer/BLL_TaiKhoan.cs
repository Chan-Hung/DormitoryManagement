using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_TaiKhoan
    {
        QuanLyKTXModel dbs = new QuanLyKTXModel();
        
        public List<TaiKhoan> SelectTaiKhoan()
        {
            return dbs.TaiKhoans.ToList();
        }
        public bool insertTaiKhoan(ref string err, string manv, string tendangnhap, string matkhau, string maloaitaikhoan)
        {
            bool flag = false;
            try
            {
                TaiKhoan tk = new TaiKhoan();
                tk.MaNV = manv;
                tk.TenDangNhap = tendangnhap;
                tk.MatKhau = matkhau;
                tk.MaLoaiTaiKhoan = maloaitaikhoan;
                dbs.TaiKhoans.Add(tk);
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
                var tk = dbs.TaiKhoans.Find(manv);
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
            var sinhvien = dbs.SinhViens.Find(manv);
            if (sinhvien != null)
            {
                dbs.SinhViens.Remove(sinhvien);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }

    }
}
