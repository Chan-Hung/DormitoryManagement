using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("LoaiTaiKhoan")]
    public partial class LoaiTaiKhoan
    {
        public LoaiTaiKhoan()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        [Key]
        [StringLength(2)]
        public string MaLoaiTaiKhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoaiTaiKhoan { get; set; }

        [Required]
        public string ChucNang { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
        public LoaiTaiKhoan(string MaLoaiTaiKhoan, string TenLoaiTaiKhoan, string ChucNang)
        {
            this.MaLoaiTaiKhoan = MaLoaiTaiKhoan;
            this.TenLoaiTaiKhoan = TenLoaiTaiKhoan;
            this.ChucNang = ChucNang;
        }
    }
}
