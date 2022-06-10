using System.Data.Entity.ModelConfiguration;

namespace DormitoryManagement.Configurations
{
    public class RoomTypeConfig : EntityTypeConfiguration<RoomType>
    {
        public RoomTypeConfig()
        {
            Property(e => e.RoomTypeID)
            .IsFixedLength()
            .IsUnicode(false);
        }
    }
}