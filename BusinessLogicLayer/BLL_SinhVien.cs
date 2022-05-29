using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_SinhVien
    {
        QuanLyKTXModel dbs = new QuanLyKTXModel();

        public List<SinhVien> SelectSinhVien() { return dbs.SinhViens.ToList<SinhVien>(); }
        public bool InsertSinhVien(ref string err, string maSV, string tenSV, string gioiTinh, string SDT, string maTruong, string maPhong)
        {
            bool flag = false;
            try
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = maSV;
                sv.TenSV = tenSV;
                sv.GioiTinh = gioiTinh;
                sv.SDT = SDT;
                sv.MaTruong = maTruong;
                sv.MaPhong = maPhong;
                dbs.SinhViens.Add(sv);
                dbs.SaveChanges();
                flag = true;
            }
            catch (SqlException)
            {
                err = "Lỗi";
            }
            return flag;

        }
        public int UpdateSinhVien(ref string err, string maSV, string tenSV, string gioiTinh, string SDT, string maTruong, string maPhong)
        {
            SqlParameter MaSinhVien = new SqlParameter("@MaSinhVien", maSV);
            SqlParameter TenSinhVien = new SqlParameter("@TenSinhVien", tenSV);
            SqlParameter GioiTinh = new SqlParameter("@GioiTinh", gioiTinh);
            SqlParameter SoDienThoai = new SqlParameter("@SoDienThoai", SDT);
            SqlParameter MaTruong = new SqlParameter("@MaTruong", maTruong);
            SqlParameter MaPhong = new SqlParameter("@MaPhong", maPhong);
            return dbs.Database.ExecuteSqlCommand("sp_UpdateSinhVien @MaSinhVien, @TenSinhVien, @GioiTinh, @SoDienThoai, @MaTruong, @MaPhong",
                                                       MaSinhVien, TenSinhVien, GioiTinh, SoDienThoai, MaTruong, MaPhong);
        }
        public int DeleteSinhVien(ref string err, string maSV)
        {
            SqlParameter MaSinhVien = new SqlParameter("@MaSinhVien", maSV);
            return dbs.Database.ExecuteSqlCommand("sp_DeleteSinhVien @MaSinhVien",
                                                       MaSinhVien);
        }
    }
    
}
