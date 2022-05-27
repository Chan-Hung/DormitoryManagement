namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SVHetHopDong2022
    {
        [StringLength(10)]
        public string MaSV { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TenSV { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime NgayKTHD { get; set; }
    }
}
