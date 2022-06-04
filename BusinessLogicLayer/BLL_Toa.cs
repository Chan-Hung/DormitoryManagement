using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_Toa
    {
        QuanLyKTXModel dbs = new QuanLyKTXModel();
        public List<Toa> SelectToa()
        {
            return dbs.Toas.ToList();
        }
        public bool InsertToa(ref string err, string matoa, short sotang, int succhua, short sophongtoida)
        {
            bool flag = false;
            try
            {
                Toa toa = new Toa();
                toa.MaToa = matoa;
                toa.SoTang = sotang;
                toa.SucChua = succhua;
                toa.SoPhongToiDa = sophongtoida;
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
    }
}
