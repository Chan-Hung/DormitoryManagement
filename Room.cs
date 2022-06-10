using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("Room")]
    public partial class Room
    {
        public Room()
        {
            DienNuocSuDungs = new HashSet<ElectricityAndWaterBill>();
            SinhViens = new HashSet<Student>();
        }

        [Key]
        [StringLength(3)]
        public string RoomID { get; set; }

        [StringLength(2)]
        public string BuildingID { get; set; }

        [StringLength(3)]
        public string RoomTypeID { get; set; }

        [Required]
        [StringLength(10)]
        public string State { get; set; }

        public virtual ICollection<ElectricityAndWaterBill> DienNuocSuDungs { get; set; }

        public virtual RoomType RoomType { get; set; }

        public virtual Building Building { get; set; }

        public virtual ICollection<Student> SinhViens { get; set; }
        public Room(string RoomID,string BuildingID, string RoomTypeID, string State)
        {
            this.RoomID = RoomID;
            this.BuildingID = BuildingID;
            this.RoomTypeID = RoomTypeID;
            this.State = State;
        }
    }
}
