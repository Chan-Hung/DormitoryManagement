using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("LoaiPhong")]
    public partial class RoomType
    {
        public RoomType()
        {
            Phongs = new HashSet<Room>();
        }

        [Key]
        [StringLength(3)]
        public string MaLoaiPhong { get; set; }

        [Required]
        [StringLength(50)]
        public string TenloaiPhong { get; set; }

        public int Gia { get; set; }

        public virtual ICollection<Room> Phongs { get; set; }
        public RoomType(string MaLoaiPhong, string TenLoaiPhong, int Gia)
        {
            this.MaLoaiPhong = MaLoaiPhong;
            this.TenloaiPhong = TenLoaiPhong;
            this.Gia = Gia;
        }
    }
}
