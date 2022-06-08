using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
namespace DormitoryManagement.BusinessLogicLayer
{

    public class BLL_TienDien
    {
        DormitoryContext dbs = new DormitoryContext();
        public List<ElectricityAndWaterBill> SelectTienDien()
        {
            return dbs.DienNuocSuDungs.ToList();
        }
        public bool InsertTienDien(ref string err, string mahoadon, string maphong, DateTime ngaylap, int sodientieuthu, int sonuoctieuthu, string trangthai)
        {
            bool flag = false;
            try
            {
                ElectricityAndWaterBill dnsd = new ElectricityAndWaterBill();
                dnsd.MaHoaDon = mahoadon;
                dnsd.MaPhong = maphong;
                dnsd.NgayLap = ngaylap.Date;
                dnsd.SoDienTieuThu = sodientieuthu;
                dnsd.SoNuocTieuthu = sonuoctieuthu;
                dnsd.TrangThai = trangthai;
                dbs.DienNuocSuDungs.Add(dnsd);
                dbs.SaveChanges();
                flag = true;
            }
            catch (SqlException)
            {
                err = "Lỗi";
            }
            return flag;
        }
        public bool UpdateTienDien(ref string err, string mahoadon, string maphong, DateTime ngaylap, int sodientieuthu, int sonuoctieuthu, string trangthai)
        {
            bool flag = false;
            try
            {
                var dnsd = dbs.DienNuocSuDungs.Find(mahoadon);
                if (dnsd != null)
                {

                    dnsd.MaHoaDon = mahoadon;
                    dnsd.MaPhong = maphong;
                    dnsd.NgayLap = ngaylap.Date;
                    dnsd.SoDienTieuThu = sodientieuthu;
                    dnsd.SoNuocTieuthu = sonuoctieuthu;
                    dnsd.TrangThai = trangthai;
                    dbs.SaveChanges();
                    flag = true;
                }
            }
            catch (SqlException)
            {
                err = "Lỗi";
            }
            return flag;
        }
        public bool DeleteTienDien(ref string err, string mahoadon)
        {
            bool flag = false;
            var dnsd = dbs.DienNuocSuDungs.Find(mahoadon);
            if (dnsd != null)
            {
                dbs.DienNuocSuDungs.Remove(dnsd);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }
        public List<ElectricityAndWaterBill> SelectChuaThanhToan()
        {
            return dbs.DienNuocSuDungs.Where(x=>x.TrangThai=="Chưa thanh toán").ToList();
        }
        public bool ThanhToan(ref string err, string mahoadon)
        {
            bool flag = false;
            try
            {
                var dnsd = dbs.DienNuocSuDungs.Find(mahoadon);
                if (dnsd != null)
                {
                    dnsd.TrangThai = "Đã thanh toán";
                    dbs.SaveChanges();
                    flag = true;
                }
            }
            catch (SqlException)
            {
                err = "Lỗi";
            }
            return flag;
        }
        //Kiểm tra không trùng khóa chính (Mã hóa đơn)
        public bool checkMaHoaDon(string mahoadon)
        {
            var hoadon = dbs.DienNuocSuDungs.Where(x => x.MaHoaDon == mahoadon).FirstOrDefault();
            if (hoadon == null) return true;
            return false;
        }
    }
}
