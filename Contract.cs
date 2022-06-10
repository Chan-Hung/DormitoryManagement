using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("HopDongThuePhong")]
    public partial class Contract
    {
        [Key]
        [StringLength(5)]
        public string ContractID { get; set; }

        [StringLength(10)]
        public string StudentID { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKTHD { get; set; }

        public virtual Student SinhVien { get; set; }
        public Contract(string ContractID, string StudentID, DateTime NgayKHD, DateTime NgayKTHD)
        {
            this.ContractID = ContractID;
            this.StudentID = StudentID;
            this.NgayKHD = NgayKHD.Date;
            this.NgayKTHD = NgayKTHD.Date;
        }
        public Contract()
        {

        }
    }
}
