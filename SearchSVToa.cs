namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SearchSVToa")]
    public partial class SearchSVToa
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaSV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TenSV { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string GioiTinh { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(5)]
        public string MaTruong { get; set; }

        [StringLength(3)]
        public string MaPhong { get; set; }

        [StringLength(2)]
        public string MaToa { get; set; }
    }
}
