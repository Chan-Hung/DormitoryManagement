using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_SinhVien
    {
        QuanLyKTXModel dbs = new QuanLyKTXModel();

        public List<SinhVien> SelectSinhVien() 
        { 
            return dbs.SinhViens.ToList(); 
        }
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
                err = "Đã xảy ra lỗi";
            }
            return flag;

        }
        public bool UpdateSinhVien(ref string err, string maSV, string tenSV, string gioiTinh, string SDT, string maTruong, string maPhong)
        {
            bool flag = false;
            try
            {
                var sinhvien = dbs.SinhViens.Find(maSV);
                if (sinhvien != null)
                {
                    sinhvien.TenSV = tenSV;
                    sinhvien.GioiTinh = gioiTinh;
                    sinhvien.SDT = SDT;
                    sinhvien.MaTruong = maTruong;
                    sinhvien.MaPhong = maPhong;
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

        
        public bool DeleteSinhVien(ref string err, string maSV)
        {
        bool flag = false;
        var sinhvien = dbs.SinhViens.Find(maSV);
        if (sinhvien != null)
            {
                dbs.SinhViens.Remove(sinhvien);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }
        public List<SinhVien> searchMaSinhVien(string masv)
        {
            return dbs.SinhViens.Where(x => x.MaSV == masv).ToList();
        }
        public List<SinhVien> searchTenSinhVien(string tenSV)
        {
            return dbs.SinhViens.Where(x => x.TenSV.Contains(tenSV)).ToList();
        }
        public Object searchTenToa(string toa)
        {
            
            var ShowToa= dbs.SinhViens.Join(dbs.Phongs, sinhVien => sinhVien.MaPhong, phong => phong.MaPhong, (sinhVien, phong) => new { MaSV = sinhVien.MaSV, TenSV = sinhVien.TenSV, GioiTinh = sinhVien.GioiTinh, MaTruong = sinhVien.MaTruong, MaPhong = sinhVien.MaPhong, MaToa = phong.MaToa}).Where(toaa=>toaa.MaToa == toa).ToList();
            return ShowToa;
        }
        public Object tienPhongCuaSV()
        {
            var tienPhongCuaSV = dbs.SinhViens.Join(dbs.Phongs, sinhVien => sinhVien.MaPhong, phong => phong.MaPhong, (sinhVien, phong) => new { SinhVien = sinhVien, Phong = phong})
                .Join(dbs.LoaiPhongs, phong=>phong.Phong.MaLoaiPhong, loaiPhong=>loaiPhong.MaLoaiPhong, (phong, loaiPhong)=> new {MaSV = phong.SinhVien.MaSV,TenSV = phong.SinhVien.TenSV,MaPhong = phong.SinhVien.MaPhong, MaLoaiPhong = phong.Phong.MaLoaiPhong,Gia = (loaiPhong.Gia * 10).ToString()}).ToList();
            return tienPhongCuaSV;
        }
    }
    
}
