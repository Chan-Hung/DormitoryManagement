namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SoNVTheoLoaiNV")]
    public partial class SoNVTheoLoaiNV
    {
        [Key]
        [StringLength(50)]
        public string CongViec { get; set; }

        public int? SoLuongNV { get; set; }
    }
}
