using System.Data.Entity.ModelConfiguration;

namespace DormitoryManagement.Configurations
{
    public class EmployeeTypeConfig : EntityTypeConfiguration<EmployeeType>
    {
        public EmployeeTypeConfig()
        {
            Property(e => e.MaLoaiNV)
            .IsFixedLength()
            .IsUnicode(false);
        }

    }
}