namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDongThuePhong")]
    public partial class HopDongThuePhong
    {
        [Key]
        [StringLength(5)]
        public string MaHD { get; set; }

        [StringLength(10)]
        public string MaSV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKTHD { get; set; }

        public virtual SinhVien SinhVien { get; set; }
        public HopDongThuePhong(string MaHD, string MaSV, DateTime NgayKHD, DateTime NgayKTHD)
        {
            this.MaHD = MaHD;
            this.MaSV = MaSV;
            this.NgayKHD = NgayKHD.Date;
            this.NgayKTHD = NgayKTHD.Date;
        }
        public HopDongThuePhong()
        {

        }
    }
}
