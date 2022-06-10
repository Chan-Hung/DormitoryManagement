using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("Employee")]
    public partial class Employee
    {
        public Employee() => TaiKhoans = new HashSet<Account>();

        [Key]
        [StringLength(5)]
        public string EmployeeID { get; set; }

        [StringLength(2)]
        public string EmployeeTypeID { get; set; }

        [StringLength(2)]
        public string BuildingID { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }

        [StringLength(10)]
        public string TelephoneNumber { get; set; }

        public int Salary { get; set; }

        public virtual EmployeeType LoaiNhanVien { get; set; }

        public virtual Building Toa { get; set; }

        public virtual ICollection<Account> TaiKhoans { get; set; }
       
        public Employee(string EmployeeID, string EmployeeTypeID, string BuildingID, string EmployeeName, string TelephoneNumber, int Salary)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeTypeID = EmployeeTypeID;
            this.BuildingID = BuildingID;
            this.EmployeeName = EmployeeName;
            this.TelephoneNumber = TelephoneNumber;
            this.Salary = Salary;

        }
    }
}
