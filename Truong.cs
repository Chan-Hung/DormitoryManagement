namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Truong")]
    public partial class Truong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Truong()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        [Key]
        [StringLength(5)]
        public string MaTruong { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTruong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVien> SinhViens { get; set; }

        public Truong(string MaTruong, string TenTruong)
        {
            this.MaTruong = MaTruong;
            this.TenTruong = TenTruong;
        }
    }
}
