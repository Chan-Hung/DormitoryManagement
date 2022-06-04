using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("LoaiNhanVien")]
    public partial class LoaiNhanVien
    {
        public LoaiNhanVien()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        [StringLength(2)]
        public string MaLoaiNV { get; set; }

        [Required]
        [StringLength(50)]
        public string CongViec { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
        public LoaiNhanVien(string MaLoaiNV, string CongViec)
        {
            this.MaLoaiNV = MaLoaiNV;
            this.CongViec = CongViec;
        }
    }
}
