using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_HopDong
    {
        QuanLyKTXModel dbs = new QuanLyKTXModel();

        public List<HopDongThuePhong> SelectHopDong()
        {
            return dbs.HopDongThuePhongs.ToList();
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
                    hopDong.NgayKHD = ngaykhd;
                    hopDong.NgayKTHD = ngaykthd;
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
