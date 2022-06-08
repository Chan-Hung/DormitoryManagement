using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("Toa")]
    public partial class Building
    {
        public Building()
        {
            NhanViens = new HashSet<Employee>();
            Phongs = new HashSet<Room>();
        }

        [Key]
        [StringLength(2)]
        public string MaToa { get; set; }

        public short SoTang { get; set; }

        public int SucChua { get; set; }

        public short SoPhongToiDa { get; set; }

        public virtual ICollection<Employee> NhanViens { get; set; }

        public virtual ICollection<Room> Phongs { get; set; }
        public Building(string MaToa, short SoTang, int SucChua, short SoPhongToiDa)
        {
            this.MaToa = MaToa;
            this.SoTang = SoTang;
            this.SucChua = SucChua;
            this.SoPhongToiDa = SoPhongToiDa;
        }
    }
}
