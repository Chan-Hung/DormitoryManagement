using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_HopDong
    {
        DormitoryContext dbs = new DormitoryContext();

        public List<Contract> SelectHopDong()
        {
            return dbs.HopDongThuePhongs.ToList();
        }

        public bool InsertHopDong(ref string err, string mahd, string masv, DateTime ngaykhd, DateTime ngaykthd)
        {
            bool flag = false;
            try
            {
                Contract hopDong = new Contract();

                hopDong.MaHD = mahd;
                hopDong.MaSV = masv;
                hopDong.NgayKHD = ngaykhd;
                hopDong.NgayKTHD = ngaykthd;
                dbs.HopDongThuePhongs.Add(hopDong);
                dbs.SaveChanges();
                flag = true;
            }
            catch (SqlException)
            {
                err = "Đã xảy ra lỗi";
            }
            return flag;
        }

        public bool UpdateHopDong(ref string err, string mahd, string masv, DateTime ngaykhd, DateTime ngaykthd)
        {
            bool flag = false;
            try
            {
                var hopDong = dbs.HopDongThuePhongs.Find(mahd);
                if (hopDong != null)
                {
                    hopDong.MaHD = mahd;
                    hopDong.MaSV = masv;
                    hopDong.NgayKHD = ngaykhd.Date;
                    hopDong.NgayKTHD = ngaykthd.Date;
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
    }
}