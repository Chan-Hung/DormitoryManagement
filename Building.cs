using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DormitoryManagement
{
    [Table("Building")]
    public partial class Building
    {
        public Building()
        {
            NhanViens = new HashSet<Employee>();
            Phongs = new HashSet<Room>();
        }

        [Key]
        [StringLength(2)]
        public string BuildingID { get; set; }

        public short Floor { get; set; }

        public int Capacity { get; set; }

        public short NumberOfRooms { get; set; }

        public virtual ICollection<Employee> NhanViens { get; set; }

        public virtual ICollection<Room> Phongs { get; set; }
        public Building(string BuildingID, short Floor, int Capacity, short NumberOfRooms)
        {
            this.BuildingID = BuildingID;
            this.Floor = Floor;
            this.Capacity = Capacity;
            this.NumberOfRooms = NumberOfRooms;
        }
    }
}
