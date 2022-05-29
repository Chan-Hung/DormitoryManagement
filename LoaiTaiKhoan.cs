namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiTaiKhoan")]
    public partial class LoaiTaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
        public LoaiTaiKhoan(string MaLoaiTaiKhoan, string TenLoaiTaiKhoan, string ChucNang)
        {
            this.MaLoaiTaiKhoan = MaLoaiTaiKhoan;
            this.TenLoaiTaiKhoan = TenLoaiTaiKhoan;
            this.ChucNang = ChucNang;
        }
    }
}
