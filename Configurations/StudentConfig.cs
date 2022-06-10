using System.Data.Entity.ModelConfiguration;

namespace DormitoryManagement.Configurations
{
    public class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            Property(e => e.StudentId)
            .IsUnicode(false);

            Property(e => e.GioiTinh)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.SDT)
            .IsFixedLength()
            .IsUnicode(false);

            Property(e => e.MaTruong)
            .IsUnicode(false);

            Property(e => e.MaPhong)
            .IsFixedLength()
            .IsUnicode(false);

            HasMany(e => e.HopDongThuePhongs)
            .WithOptional(e => e.SinhVien)
            .WillCascadeOnDelete();
        }
    }
}
