using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("LoaiNhanVien")]
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            NhanViens = new HashSet<Employee>();
        }

        [Key]
        [StringLength(2)]
        public string MaLoaiNV { get; set; }

        [Required]
        [StringLength(50)]
        public string CongViec { get; set; }

        public virtual ICollection<Employee> NhanViens { get; set; }
        public EmployeeType(string MaLoaiNV, string CongViec)
        {
            this.MaLoaiNV = MaLoaiNV;
            this.CongViec = CongViec;
        }
    }
}
