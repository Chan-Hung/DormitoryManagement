using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_Phong
    {
        //DataAccessLayer.DAL dal = new DataAccessLayer.DAL();
        DormitoryContext dbs = new DormitoryContext();
        public List<Phong> SelectPhong()
        {
            return dbs.Phongs.ToList();
        }
        public bool InsertPhong(ref string err, string maphong, string maloaiphong, string matoa, string trangthai)
        {
            bool flag = false;
            try
            {
                Phong phong = new Phong();
                phong.MaPhong = maphong;
                phong.MaLoaiPhong = maloaiphong;
                phong.MaToa = matoa;
                phong.TrangThai = trangthai;
                dbs.Phongs.Add(phong);
                dbs.SaveChanges();
                flag = true;

            }
            catch (SqlException)
            {
                err = "Loi rui!!!";
            }
            return flag;
        }
        public bool UpdatePhong(ref string err, string maphong, string maloaiphong, string matoa, string trangthai)
        {
            bool flag = false;
            try
            {
                var phong = dbs.Phongs.Find(maphong);
                if (phong!=null){
                    phong.MaPhong = maphong;
                    phong.MaLoaiPhong = maloaiphong;
                    phong.MaToa = matoa;
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
        public List<Phong> ShowPhongTrong()
        {
            return dbs.Phongs.Where(x=>x.TrangThai == "Còn").ToList();
        }
        public bool checkMaPhong(string maPhong)
        {
            Phong phong = dbs.Phongs.Where(x => x.MaPhong == maPhong).FirstOrDefault();
            if (phong != null) return false;
            return true;
        }
    }
}
