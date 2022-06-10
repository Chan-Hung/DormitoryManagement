using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_Toa
    {
        DormitoryContext dbs = new DormitoryContext();
        public List<Building> SelectToa()
        {
            return dbs.Toas.ToList();
        }
        public bool InsertToa(ref string err, string matoa, short sotang, int succhua, short sophongtoida)
        {
            bool flag = false;
            try
            {
                Building toa = new Building();
                toa.BuildingID = matoa;
                toa.Floor = sotang;
                toa.Capacity = succhua;
                toa.NumberOfRooms = sophongtoida;
                dbs.Toas.Add(toa);
                dbs.SaveChanges();
                flag = true;
            }
            catch (SqlException)
            {
                err = "Lỗi";
            }
            return flag;
        }
        public bool UpdateToa(ref string err, string matoa, short sotang, int succhua, short sophongtoida)
        {
            bool flag = false;
            try
            {
                var toa = dbs.Toas.Find(matoa);
                if (toa != null)
                {
                    toa.BuildingID = matoa;
                    toa.Floor = sotang;
                    toa.Capacity = succhua;
                    toa.NumberOfRooms = sophongtoida;
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
        public bool checkMaToa(string matoa)
        {
            var toa = dbs.Toas.Where(x => x.BuildingID == matoa).FirstOrDefault();
            if (toa == null) return true;
            return false;
        }
    }
}
