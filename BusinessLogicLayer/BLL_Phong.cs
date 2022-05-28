using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_Phong
    {
        QuanLyKTXModel dbs = new QuanLyKTXModel();
        public List<Phong> SelectPhong() { return dbs.Phongs.ToList<Phong>(); }
        public bool InsertPhong(ref string err, string maphong, string matoa, string maloaiphong, string trangthai)
        {
            bool flag = false;
            try
            {
                Phong phong = new Phong();
                phong.MaPhong = maphong;
                phong.MaToa = matoa;
                phong.MaLoaiPhong = maloaiphong;
                phong.TrangThai = trangthai;
                dbs.SaveChanges();
                flag = true;

            }
            catch (SqlException)
            {
                err = "Loi rui!!!";
            }
            return flag;
        }
        public bool UpdatePhong(ref string err, string maphong, string matoa, string maloaiphong, string trangthai)
        {
            bool flag = false;
            try
            {
                var phong = dbs.Phongs.Find(maphong);
                if (phong != null)
                {
                    phong.MaPhong = maphong;
                    phong.MaToa = matoa;
                    phong.MaLoaiPhong = maloaiphong;
                    phong.TrangThai = trangthai;
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
