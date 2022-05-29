namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Toa")]
    public partial class Toa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Toa()
        {
            NhanViens = new HashSet<NhanVien>();
            Phongs = new HashSet<Phong>();
        }

        [Key]
        [StringLength(2)]
        public string MaToa { get; set; }

        public short SoTang { get; set; }

        public int SucChua { get; set; }

        public short SoPhongToiDa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }
        public Toa(string MaToa, short SoTang, int SucChua, short SoPhongToiDa)
        {
            this.MaToa = MaToa;
            this.SoTang = SoTang;
            this.SucChua = SucChua;
            this.SoPhongToiDa = SoPhongToiDa;
        }
    }
}
