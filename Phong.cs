using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("Phong")]
    public partial class Phong
    {
        public Phong()
        {
            DienNuocSuDungs = new HashSet<ElectricityAndWaterBill>();
            SinhViens = new HashSet<Student>();
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

        public virtual ICollection<ElectricityAndWaterBill> DienNuocSuDungs { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }

        public virtual Toa Toa { get; set; }

        public virtual ICollection<Student> SinhViens { get; set; }
        public Phong(string MaPhong,string MaToa, string MaLoaiPhong, string TrangThai)
        {
            this.MaPhong = MaPhong;
            this.MaToa = MaToa;
            this.MaLoaiPhong = MaLoaiPhong;
            this.TrangThai = TrangThai;
        }
    }
}
