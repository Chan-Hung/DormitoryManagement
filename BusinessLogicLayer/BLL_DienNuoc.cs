using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DormitoryManagement.BusinessLogicLayer
{
    class BLL_DienNuoc
    {
        QuanLyKTXModel dbs = new QuanLyKTXModel();

        public List<DienNuocSuDung> SelectDienNuoc()
        {
            return dbs.DienNuocSuDungs.ToList();
        }
        public bool insertDienNuoc(ref string err, string mahoadon, string maphong, DateTime ngaylap, int sodientieuthu, int sonuoctieuthu, string trangthai)
        {

            bool flag = false;
            try
            {
                DienNuocSuDung dn = new DienNuocSuDung();
                dn.MaHoaDon = mahoadon;
                dn.MaPhong = maphong;
                dn.NgayLap = ngaylap;
                dn.SoDienTieuThu = sodientieuthu;
                dn.SoNuocTieuthu = sonuoctieuthu;
                dn.TrangThai = trangthai;
                dbs.DienNuocSuDungs.Add(dn);
                dbs.SaveChanges();
                flag = true;
            }
            catch (SqlException)
            {
                err = "Đã xảy ra lỗi";
            }
            return flag;
        }
    }
}
