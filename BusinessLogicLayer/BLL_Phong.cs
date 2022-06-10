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
        public List<Room> SelectPhong()
        {
            return dbs.Phongs.ToList();
        }
        public bool InsertPhong(ref string err, string maphong, string maloaiphong, string matoa, string trangthai)
        {
            bool flag = false;
            try
            {
                Room phong = new Room();
                phong.RoomID = maphong;
                phong.RoomTypeID = maloaiphong;
                phong.BuildingID = matoa;
                phong.State = trangthai;
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
                    phong.RoomID = maphong;
                    phong.RoomTypeID = maloaiphong;
                    phong.BuildingID = matoa;
                    phong.State = trangthai;
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
        public List<Room> ShowPhongTrong()
        {
            return dbs.Phongs.Where(x=>x.State == "Còn").ToList();
        }
        public bool checkMaPhong(string maPhong)
        {
            Room phong = dbs.Phongs.Where(x => x.RoomID == maPhong).FirstOrDefault();
            if (phong != null) return false;
            return true;
        }
    }
}
