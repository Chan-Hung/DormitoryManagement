using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_SinhVien
    {
        QuanLyKTXModel dbs = new QuanLyKTXModel();
        public List<SinhVien> SelectSinhVien() { return dbs.SinhViens.ToList(); }
    }
}
