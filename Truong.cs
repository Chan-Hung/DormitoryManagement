using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("Truong")]
    public partial class Truong
    {
        public Truong()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        [Key]
        [StringLength(5)]
        public string MaTruong { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTruong { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }

        public Truong(string MaTruong, string TenTruong)
        {
            this.MaTruong = MaTruong;
            this.TenTruong = TenTruong;
        }
    }
}
