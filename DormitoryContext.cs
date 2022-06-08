using System.Data.Entity;

namespace DormitoryManagement
{
    public partial class DormitoryContext : DbContext
    {
        public DormitoryContext()
            : base("name=QuanLyKTXModel1")
        {
            Database.SetInitializer(new Initializer());
        }

        public virtual DbSet<ElectricityAndWaterBill> DienNuocSuDungs { get; set; }
        public virtual DbSet<HopDongThuePhong> HopDongThuePhongs { get; set; }
        public virtual DbSet<LoaiNhanVien> LoaiNhanViens { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<Student> SinhViens { get; set; }
        public virtual DbSet<Account> TaiKhoans { get; set; }
        public virtual DbSet<Toa> Toas { get; set; }
        public virtual DbSet<Truong> Truongs { get; set; }
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Configurations.StudentConfig());

            modelBuilder.Configurations.Add(new Configurations.AccountConfig());

            modelBuilder.Configurations.Add(new Configurations.ElectricityAndWaterBillConfig());

            modelBuilder.Entity<HopDongThuePhong>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HopDongThuePhong>()
                .Property(e => e.MaSV)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiNhanVien>()
                .Property(e => e.MaLoaiNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.MaLoaiPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiTaiKhoan>()
                .Property(e => e.MaLoaiTaiKhoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiTaiKhoan>()
                .Property(e => e.TenLoaiTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaLoaiNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaToa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaToa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaLoaiPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.DienNuocSuDungs)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Toa>()
                .Property(e => e.MaToa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Truong>()
                .Property(e => e.MaTruong)
                .IsUnicode(false);
        }
    }
}
