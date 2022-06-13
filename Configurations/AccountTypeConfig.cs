using System.Data.Entity.ModelConfiguration;

namespace DormitoryManagement.Configurations
{
    public class AccountTypeConfig : EntityTypeConfiguration<AccountType>
    {
        public AccountTypeConfig()
        {
            Property(e => e.MaLoaiTaiKhoan)
               .IsFixedLength()
               .IsUnicode(false);

            Property(e => e.TenLoaiTaiKhoan)
                .IsUnicode(false);
        }
    }
}
