using System.Data.Entity.ModelConfiguration;

namespace DormitoryManagement.Configurations
{
    public class RoomConfig : EntityTypeConfiguration<Room>
    {
        public RoomConfig()
        {
            Property(e => e.RoomID)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.BuildingID)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.RoomTypeID)
            .IsFixedLength()
            .IsUnicode(false);

            HasMany(e => e.ElectricityAndWaterBills)
            .WithRequired(e => e.Phong)
            .WillCascadeOnDelete(false);
        }
    }
}
