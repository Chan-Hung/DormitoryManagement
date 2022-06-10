using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("RoomType")]
    public partial class RoomType
    {
        public RoomType()
        {
            Rooms = new HashSet<Room>();
        }

        [Key]
        [StringLength(3)]
        public string RoomTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomTypeName { get; set; }

        public int Fee { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
        public RoomType(string RoomTypeID, string RoomTypeName, int Fee)
        {
            this.RoomTypeID = RoomTypeID;
            this.RoomTypeName = RoomTypeName;
            this.Fee = Fee;
        }
    }
}
