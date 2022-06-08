using System.Data.Entity.ModelConfiguration;


namespace DormitoryManagement.Configurations
{
    class SchoolConfig : EntityTypeConfiguration<School>
    {
        public SchoolConfig()
        {
            Property(e => e.MaTruong)
            .IsUnicode(false);
        }
    }
}