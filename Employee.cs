using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("NhanVien")]
    public partial class Employee
    {
        public NhanVien() => TaiKhoans = new HashSet<Account>();
        public Employee() => TaiKhoans = new HashSet<TaiKhoan>();

        [Key]
        [StringLength(5)]
        public string MaNV { get; set; }

        [StringLength(2)]
        public string MaLoaiNV { get; set; }

        [StringLength(2)]
        public string MaToa { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNV { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        public int Luong { get; set; }

        public virtual EmployeeType LoaiNhanVien { get; set; }

        public virtual Building Toa { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
        public Employee(string MaNV, string MaLoaiNV, string MaToa, string TenNV, string SDT, int Luong)
        public virtual ICollection<Account> TaiKhoans { get; set; }
        public NhanVien(string MaNV, string MaLoaiNV, string MaToa, string TenNV, string SDT, int Luong)
        {
            this.MaNV = MaNV;
            this.MaLoaiNV = MaLoaiNV;
            this.MaToa = MaToa;
            this.TenNV = TenNV;
            this.SDT = SDT;
            this.Luong = Luong;

        }
    }
}
