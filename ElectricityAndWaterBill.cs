using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("DienNuocSuDung")]
    public partial class ElectricityAndWaterBill
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
        public ElectricityAndWaterBill(string MaHoaDon, string MaPhong, DateTime NgayLap, int SoDienTieuThu, int SoNuocTieuThu, string TrangThai)
        public virtual Room Phong { get; set; }
        public DienNuocSuDung(string MaHoaDon, string MaPhong, DateTime NgayLap, int SoDienTieuThu, int SoNuocTieuThu, string TrangThai)
        {
            this.MaHoaDon = MaHoaDon;
            this.MaPhong = MaPhong;
            this.NgayLap = NgayLap;
            this.SoDienTieuThu = SoDienTieuThu;
            this.SoNuocTieuthu = SoNuocTieuThu;
            this.TrangThai = TrangThai;
        }

        public ElectricityAndWaterBill()
        {
        }
    }
}
