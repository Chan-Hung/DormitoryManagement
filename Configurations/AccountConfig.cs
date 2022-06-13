using System.Data.Entity.ModelConfiguration;

namespace DormitoryManagement.Configurations
{
    public class AccountConfig : EntityTypeConfiguration<Account>
    {
        public AccountConfig()
        {
            Property(e => e.MaNV)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.TenDangNhap)
            .IsUnicode(false);

            Property(e => e.MatKhau)
            .IsUnicode(false);

            Property(e => e.MaLoaiTaiKhoan)
            .IsFixedLength()
            .IsUnicode(false);
        }
    }
}
