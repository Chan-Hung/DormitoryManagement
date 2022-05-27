namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TienPhongMoiSV")]
    public partial class TienPhongMoiSV
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaSV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TenSV { get; set; }

        [StringLength(3)]
        public string MaPhong { get; set; }

        [Column("Mã loại phòng")]
        [StringLength(3)]
        public string Mã_loại_phòng { get; set; }

        [Column("Giá phòng")]
        [StringLength(100)]
        public string Giá_phòng { get; set; }
    }
}
