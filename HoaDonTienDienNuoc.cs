namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonTienDienNuoc")]
    public partial class HoaDonTienDienNuoc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaHoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string MaPhong { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime NgayLap { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoDienTieuThu { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoNuocTieuthu { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        [Column("Tổng hóa đơn")]
        public int? Tổng_hóa_đơn { get; set; }
    }
}
