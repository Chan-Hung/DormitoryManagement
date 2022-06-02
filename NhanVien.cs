namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }

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

        public virtual LoaiNhanVien LoaiNhanVien { get; set; }

        public virtual Toa Toa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
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
