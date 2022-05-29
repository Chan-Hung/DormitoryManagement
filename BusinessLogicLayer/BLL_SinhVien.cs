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
        public bool UpdateSinhVien(ref string err, string maSV, string tenSV, string gioiTinh, string SDT, string maTruong, string maPhong)
        {
            bool flag = false;
            try
            {
                var sv = dbs.SinhViens.Find(maSV);
                if (sv != null)
                {
                    sv.MaSV = maSV;
                    sv.TenSV = tenSV;
                    sv.GioiTinh = gioiTinh;
                    sv.SDT = SDT;
                    sv.MaTruong = maTruong;
                    sv.MaPhong = maPhong;
                    dbs.SaveChanges();
                    flag = true;
                }
            }
            catch (SqlException)
            {
                err = "Loi rui!!!";
            }
            return flag;
        }

    }
    
}
