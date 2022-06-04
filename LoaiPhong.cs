using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("LoaiPhong")]
    public partial class LoaiPhong
    {
        public LoaiPhong()
        {
            Phongs = new HashSet<Phong>();
        }

        [Key]
        [StringLength(3)]
        public string MaLoaiPhong { get; set; }

        [Required]
        [StringLength(50)]
        public string TenloaiPhong { get; set; }

        public int Gia { get; set; }

        public virtual ICollection<Phong> Phongs { get; set; }
        public LoaiPhong(string MaLoaiPhong, string TenLoaiPhong, int Gia)
        {
            this.MaLoaiPhong = MaLoaiPhong;
            this.TenloaiPhong = TenLoaiPhong;
            this.Gia = Gia;
        }
    }
}
