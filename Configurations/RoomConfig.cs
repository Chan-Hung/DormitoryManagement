using System.Data.Entity.ModelConfiguration;

namespace DormitoryManagement.Configurations
{
    public class RoomConfig : EntityTypeConfiguration<Room>
    {
        public RoomConfig()
        {
            Property(e => e.MaPhong)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.MaToa)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.MaLoaiPhong)
            .IsFixedLength()
            .IsUnicode(false);

            HasMany(e => e.DienNuocSuDungs)
            .WithRequired(e => e.Phong)
            .WillCascadeOnDelete(false);
        }
    }
}
