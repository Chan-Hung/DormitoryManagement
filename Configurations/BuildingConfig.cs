using System.Data.Entity.ModelConfiguration;

namespace DormitoryManagement.Configurations
{
    public class BuildingConfig : EntityTypeConfiguration<Building>
    {
        public BuildingConfig()
        {
            Property(e => e.MaToa)
            .IsFixedLength()
            .IsUnicode(false);
        }
    }
}