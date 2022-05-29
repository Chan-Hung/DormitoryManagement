using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DormitoryManagement.BusinessLogicLayer
{

    public class BLL_TienDien
    {
        QuanLyKTXModel dbs = new QuanLyKTXModel();
        public List<DienNuocSuDung> SelectTienDien()
        {
            return dbs.DienNuocSuDungs.ToList();
        }
        public bool InsertTienDien(ref string err, string mahoadon, string maphong, DateTime ngaylap, int sodientieuthu, int sonuoctieuthu, string trangthai)
        {
            bool flag = false;
            try
            {
                DienNuocSuDung dnsd = new DienNuocSuDung();
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
    }
}
