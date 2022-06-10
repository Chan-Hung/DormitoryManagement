using System.Data.Entity.ModelConfiguration;

namespace DormitoryManagement.Configurations
{
    public class EmployeeConfig : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfig()
        {
            Property(e => e.EmployeeID)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.EmployeeTypeID)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.BuildingID)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.TelephoneNumber)
           .IsFixedLength()
           .IsUnicode(false);
        }
    }
}