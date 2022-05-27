namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DienNuocSuDung")]
    public partial class DienNuocSuDung
    {
        [Key]
        [StringLength(5)]
        public string MaHoaDon { get; set; }

        [Required]
        [StringLength(3)]
        public string MaPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLap { get; set; }

        public int SoDienTieuThu { get; set; }

        public int SoNuocTieuthu { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
