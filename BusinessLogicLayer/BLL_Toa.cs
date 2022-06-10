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
            return dbs.Buildings.ToList();
        }
        public bool InsertToa(ref string err, string matoa, short sotang, int succhua, short sophongtoida)
        {
            bool flag = false;
            try
            {
                Building toa = new Building();
                toa.MaToa = matoa;
                toa.SoTang = sotang;
                toa.SucChua = succhua;
                toa.SoPhongToiDa = sophongtoida;
                dbs.Buildings.Add(toa);
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
                var toa = dbs.Buildings.Find(matoa);
                if (toa != null)
                {
                    toa.MaToa = matoa;
                    toa.SoTang = sotang;
                    toa.SucChua = succhua;
                    toa.SoPhongToiDa = sophongtoida;
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
            var toa = dbs.Buildings.Where(x => x.MaToa == matoa).FirstOrDefault();
            if (toa == null) return true;
            return false;
        }
    }
}
