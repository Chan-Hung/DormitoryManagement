using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_NhanVien
    {
        DormitoryContext dbs = new DormitoryContext();

        public List<Employee> SelectNhanVien() { return dbs.NhanViens.ToList(); }
        public bool InsertNhanVien(ref string err, string maNV, string maLoaiNV, string maToa, string tenNV, string SDT, int Luong)
        {
            bool flag = false;
            try
            {
                Employee nv = new Employee();
                nv.EmployeeID = maNV;
                nv.EmployeeTypeID = maLoaiNV;
                nv.BuildingID = maToa;
                nv.TenNV = tenNV;
                nv.TelephoneNumber = SDT;
                nv.Salary = Luong;
                dbs.NhanViens.Add(nv);
                dbs.SaveChanges();
                flag = true;
            }
            catch (SqlException)
            {
                err = "Loi rui thay oi";
            }
            return flag;
        }
        public bool UpdateNhanVien(ref string err, string maNV, string maLoaiNV, string maToa, string tenNV, string SDT, int Luong)
        {
            bool flag = false;
            try
            {
                var nhanVien = dbs.NhanViens.Find(maNV);
                if (nhanVien != null)
                {
                    nhanVien.EmployeeTypeID = maLoaiNV;
                    nhanVien.BuildingID = maToa;
                    nhanVien.TenNV = tenNV;
                    nhanVien.TelephoneNumber = SDT;
                    nhanVien.Salary = Luong;
                    dbs.SaveChanges();
                    flag = true;
                }
            }
            catch (SqlException)
            {
                err = "Loi rui thay oi";
            }
            return flag;
        }
        public bool DeleteNhanVien(ref string err, string maNV)
        {
            bool flag = false;
            var toDelete = dbs.NhanViens.Find(maNV);
            if (toDelete != null)
            {
                dbs.NhanViens.Remove(toDelete);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }
        public List<Employee> searchTenNhanVien(string tennv)
        {
            return dbs.NhanViens.Where(x => x.TenNV.Contains(tennv)).ToList();
        }
        public List<Employee> searchMaNhanVien(string manv)
        {
            return dbs.NhanViens.Where(x => x.EmployeeID == manv).ToList();
        }
        public List<Employee> searchMaToa(string matoa)
        {
            return dbs.NhanViens.Where(x => x.BuildingID == matoa).ToList();
        }
        //Kiểm tra không trùng khóa chính (Mã nhân viên)
        public bool checkMaNhanVien(string manv)
        {
            var nv = dbs.NhanViens.Where(x => x.EmployeeID == manv).FirstOrDefault();
            if (nv == null) return true;
            return false;
        }
        public bool checkDinhDangMaNV(string maNV, string maLoaiNV)
        {
            //Kiểm tra định dạng nhân viên
            bool flag = false;
            Dictionary<string, string> whitelist = new Dictionary<string, string>()
            {
                {"01", "BV"},
                {"02", "LC"},
                {"03", "DB"},
                {"04", "BH"},
                {"05", "QL"},
                {"06", "VP"},
                {"07", "QT"}
            };
            foreach (var dinhDang in whitelist)
                if (maLoaiNV == dinhDang.Key && maNV.Substring(0, 2) == dinhDang.Value)
                {
                    flag = true;
                    break;
                }
            return flag;
        }
    }
}