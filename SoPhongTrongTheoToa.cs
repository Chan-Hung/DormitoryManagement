namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SoPhongTrongTheoToa")]
    public partial class SoPhongTrongTheoToa
    {
        [Key]
        [StringLength(2)]
        public string MaToa { get; set; }

        public int? SoPhongTrong { get; set; }
    }
}
