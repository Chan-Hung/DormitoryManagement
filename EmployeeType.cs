using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("EmployeeType")]
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            NhanViens = new HashSet<Employee>();
        }

        [Key]
        [StringLength(2)]
        public string EmployeeTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string JobDescription { get; set; }

        public virtual ICollection<Employee> NhanViens { get; set; }
        public EmployeeType(string EmployeeTypeID, string JobDescription)
        {
            this.EmployeeTypeID = EmployeeTypeID;
            this.JobDescription = JobDescription;
        }
    }
}
