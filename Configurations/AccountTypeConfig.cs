using System.Data.Entity.ModelConfiguration;


namespace DormitoryManagement.Configurations
{
    public class AccountTypeConfig : EntityTypeConfiguration<AccountType>
    {
        public AccountTypeConfig()
        {
            Property(e => e.AccountTypeID)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.AccountTypeName)
            .IsUnicode(false);
        }
    }
}