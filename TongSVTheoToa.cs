namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TongSVTheoToa")]
    public partial class TongSVTheoToa
    {
        [Key]
        [StringLength(2)]
        public string MaToa { get; set; }

        public int? SoLuongSV { get; set; }
    }
}
