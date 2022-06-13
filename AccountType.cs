using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("LoaiTaiKhoan")]
    public partial class AccountType
    {
        public AccountType()
        {
            TaiKhoans = new HashSet<Account>();
        }

        [Key]
        [StringLength(2)]
        public string MaLoaiTaiKhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoaiTaiKhoan { get; set; }

        [Required]
        public string ChucNang { get; set; }

        public virtual ICollection<Account> TaiKhoans { get; set; }
        public AccountType(string MaLoaiTaiKhoan, string TenLoaiTaiKhoan, string ChucNang)
        {
            this.MaLoaiTaiKhoan = MaLoaiTaiKhoan;
            this.TenLoaiTaiKhoan = TenLoaiTaiKhoan;
            this.ChucNang = ChucNang;
        }
    }
}
