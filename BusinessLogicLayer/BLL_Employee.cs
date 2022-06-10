using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace DormitoryManagement.BusinessLogicLayer
{
    public class BLL_Employee
    {
        DormitoryContext dbs = new DormitoryContext();

        public List<Employee> SelectEmployee() { return dbs.Employees.ToList(); }
        public bool InsertEmployee(ref string err, string employeeID, string employeeTypeID, string buildingID, string employeeName, string phoneNumber, int salary)
        {
            bool flag = false;
            try
            {
                Employee employee = new Employee();
                employee.EmployeeID = employeeID;
                employee.EmployeeTypeID = employeeTypeID;
                employee.BuildingID = buildingID;
                employee.EmployeeName = employeeName;
                employee.PhoneNumber = phoneNumber;
                employee.Salary = salary;
                dbs.Employees.Add(employee);
                dbs.SaveChanges();
                flag = true;
            }
            catch (SqlException)
            {
                err = "Loi rui thay oi";
            }
            return flag;
        }
        public bool UpdateEmployee(ref string err, string employeeID, string employeeTypeID, string buildingID, string employeeName, string phoneNumber, int salary)
        {
            bool flag = false;
            try
            {
                var employee = dbs.Employees.Find(employeeID);
                if (employee != null)
                {
                    employee.EmployeeTypeID = employeeTypeID;
                    employee.BuildingID = buildingID;
                    employee.EmployeeName = employeeName;
                    employee.PhoneNumber = phoneNumber;
                    employee.Salary = salary;
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
        public bool DeleteEmployee(ref string err, string employeeID)
        {
            bool flag = false;
            var deleteEmployee = dbs.Employees.Find(employeeID);
            if (deleteEmployee != null)
            {
                dbs.Employees.Remove(deleteEmployee);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }
        public List<Employee> SearchEmployeeName(string employeeName)
        {
            return dbs.Employees.Where(x => x.EmployeeName.Contains(employeeName)).ToList();
        }
        public List<Employee> SearchEmployeeID(string employeeID)
        {
            return dbs.Employees.Where(x => x.EmployeeID == employeeID).ToList();
        }
        public List<Employee> SearchBuilding(string buildingID)
        {
            return dbs.Employees.Where(x => x.BuildingID == buildingID).ToList();
        }
        //Kiểm tra không trùng khóa chính (Mã nhân viên)
        public bool CheckEmployeeID(string employeeID)
        {
            var nv = dbs.Employees.Where(x => x.EmployeeID == employeeID).FirstOrDefault();
            if (nv == null) return true;
            return false;
        }
        public bool CheckFormatEmployee(string employeeID, string employeeTypeID)
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
                if (employeeTypeID == dinhDang.Key && employeeID.Substring(0, 2) == dinhDang.Value)
                {
                    flag = true;
                    break;
                }
            return flag;
        }
    }
}