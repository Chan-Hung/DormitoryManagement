using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("Toa")]
    public partial class Toa
    {
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

        public virtual ICollection<NhanVien> NhanViens { get; set; }

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
