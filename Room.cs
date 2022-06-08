using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("Phong")]
    public partial class Room
    {
        public Room()
        {
            DienNuocSuDungs = new HashSet<DienNuocSuDung>();
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

        public virtual ICollection<DienNuocSuDung> DienNuocSuDungs { get; set; }

        public virtual RoomType LoaiPhong { get; set; }

        public virtual Building Toa { get; set; }

        public virtual ICollection<Student> SinhViens { get; set; }
        public Room(string MaPhong,string MaToa, string MaLoaiPhong, string TrangThai)
        {
            this.MaPhong = MaPhong;
            this.MaToa = MaToa;
            this.MaLoaiPhong = MaLoaiPhong;
            this.TrangThai = TrangThai;
        }
    }
}
