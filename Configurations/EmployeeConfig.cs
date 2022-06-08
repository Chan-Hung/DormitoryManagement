using System.Data.Entity.ModelConfiguration;

namespace DormitoryManagement.Configurations
{
    public class EmployeeConfig : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfig()
        {
            Property(e => e.MaNV)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.MaLoaiNV)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.MaToa)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.SDT)
           .IsFixedLength()
           .IsUnicode(false);
        }
    }
}