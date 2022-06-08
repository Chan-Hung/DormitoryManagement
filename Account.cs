using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("TaiKhoan")]
    public partial class Account
    {
        [Key]
        public int MaTaiKhoan { get; set; }

        [StringLength(5)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(255)]
        public string MatKhau { get; set; }

        [StringLength(2)]
        public string MaLoaiTaiKhoan { get; set; }

        public virtual LoaiTaiKhoan LoaiTaiKhoan { get; set; }

        public virtual NhanVien NhanVien { get; set; }
        public Account(string MaNV, string TenDangNhap, string MatKhau, string MaLoaiTaiKhoan)
        {
            this.MaNV = MaNV;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.MaLoaiTaiKhoan = MaLoaiTaiKhoan;
        }

        public Account()
        {
        }
    }
}
