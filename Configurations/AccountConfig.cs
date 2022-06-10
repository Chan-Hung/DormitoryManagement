using System.Data.Entity.ModelConfiguration;

namespace DormitoryManagement.Configurations
{
    public class AccountConfig : EntityTypeConfiguration<Account>
    {
        public AccountConfig()
        {
            Property(e => e.EmployeeID)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.Username)
                .IsUnicode(false);

            Property(e => e.Password)
                .IsUnicode(false);

            Property(e => e.AccountTypeID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
