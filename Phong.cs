namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            DienNuocSuDungs = new HashSet<DienNuocSuDung>();
            SinhViens = new HashSet<SinhVien>();
        }

        [Key]
        [StringLength(3)]
        public string MaPhong { get; set; }

        [StringLength(2)]
        public string MaToa { get; set; }

        [StringLength(3)]
        public string MaLoaiPhong { get; set; }

        [Required]
        [StringLength(10)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DienNuocSuDung> DienNuocSuDungs { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }

        public virtual Toa Toa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVien> SinhViens { get; set; }
        public Phong(string MaPhong,string MaToa, string MaLoaiPhong, string TrangThai)
        {
            this.MaPhong = MaPhong;
            this.MaToa = MaToa;
            this.MaLoaiPhong = MaLoaiPhong;
            this.TrangThai = TrangThai;
        }
    }
}
