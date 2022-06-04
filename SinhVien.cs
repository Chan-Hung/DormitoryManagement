using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("SinhVien")]
    public partial class SinhVien
    {
        public SinhVien()
        {
            HopDongThuePhongs = new HashSet<HopDongThuePhong>();
        }

        [Key]
        [StringLength(10)]
        public string MaSV { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSV { get; set; }

        [Required]
        [StringLength(1)]
        public string GioiTinh { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(5)]
        public string MaTruong { get; set; }

        [StringLength(3)]
        public string MaPhong { get; set; }

        public virtual ICollection<HopDongThuePhong> HopDongThuePhongs { get; set; }

        public virtual Phong Phong { get; set; }

        public virtual Truong Truong { get; set; }
        public SinhVien(string MaSV, string TenSV, string GioiTinh, string SDT, string MaTruong, string MaPhong)
        {
            this.MaSV = MaSV;
            this.TenSV = TenSV;
            this.GioiTinh = GioiTinh;
            this.SDT = SDT;
            this.MaTruong = MaTruong;
            this.MaPhong = MaPhong;
        }
    }
}
