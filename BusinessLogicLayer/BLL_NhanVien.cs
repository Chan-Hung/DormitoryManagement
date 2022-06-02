using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_NhanVien
    {
        QuanLyKTXModel dbs = new QuanLyKTXModel();

        public List<NhanVien> SelectNhanVien() { return dbs.NhanViens.ToList(); }
        public bool InsertNhanVien(ref string err, string maNV, string maLoaiNV, string maToa, string tenNV, string SDT, int Luong)
        {
            bool flag = false;
            try
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = maNV;
                nv.MaLoaiNV = maLoaiNV;
                nv.MaToa = maToa;
                nv.TenNV = tenNV;
                nv.SDT = SDT;
                nv.Luong = Luong;
                dbs.NhanViens.Add(nv);
                dbs.SaveChanges();
                flag = true;
            }
            catch (SqlException)
            {
                err = "Loi rui thay oi";
            }
            return flag;
        }
        public bool UpdateNhanVien(ref string err, string maNV, string maLoaiNV, string maToa, string tenNV, string SDT, int Luong)
        {
            bool flag = false;
            try
            {
                var nhanVien = dbs.NhanViens.Find(maNV);
                if (nhanVien != null)
                {
                    nhanVien.MaLoaiNV = maLoaiNV;
                    nhanVien.MaToa = maToa;
                    nhanVien.TenNV = tenNV;
                    nhanVien.SDT = SDT;
                    nhanVien.Luong = Luong;
                    dbs.SaveChanges();
                    flag = true;
                }
            }
            catch (SqlException)
            {
                err = "Loi rui thay oi";
            }
            return flag;
        }
        public bool DeleteNhanVien(ref string err, string maNV)
        {
            bool flag = false;
            var toDelete = dbs.NhanViens.Find(maNV);
            if (toDelete != null)
            {
                dbs.NhanViens.Remove(toDelete);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }
        public List<NhanVien> searchTenNhanVien(string tennv)
        {
            return dbs.NhanViens.Where(x => x.TenNV.Contains(tennv)).ToList();
        }
        public List<NhanVien> searchMaNhanVien(string manv)
        {
            return dbs.NhanViens.Where(x => x.MaNV == manv).ToList();

        }
    }
}
