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
        public virtual DbSet<EmployeeType> LoaiNhanViens { get; set; }
        public virtual DbSet<RoomType> LoaiPhongs { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
        public virtual DbSet<Employee> NhanViens { get; set; }
        public virtual DbSet<Room> Phongs { get; set; }
        public virtual DbSet<Student> SinhViens { get; set; }
        public virtual DbSet<Account> TaiKhoans { get; set; }
        //public virtual DbSet<Toa> Toas { get; set; }
        //public virtual DbSet<Truong> Truongs { get; set; }
        //public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<Building> Toas { get; set; }
        public virtual DbSet<School> Truongs { get; set; }
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Configurations.StudentConfig());

            modelBuilder.Configurations.Add(new Configurations.AccountConfig());
            modelBuilder.Configurations.Add(new Configurations.BuildingConfig());

            modelBuilder.Configurations.Add(new Configurations.EmployeeTypeConfig());

            modelBuilder.Configurations.Add(new Configurations.EmployeeConfig());

            modelBuilder.Configurations.Add(new Configurations.RoomTypeConfig());

            modelBuilder.Configurations.Add(new Configurations.RoomConfig());

            //modelBuilder.Configurations.Add(new Conf)

            //modelBuilder.Entity<DienNuocSuDung>()
            //    .Property(e => e.MaHoaDon)
            //    .IsFixedLength()
            //    .IsUnicode(false);

            modelBuilder.Configurations.Add(new Configurations.ElectricityAndWaterBillConfig());

            modelBuilder.Entity<HopDongThuePhong>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HopDongThuePhong>()
                .Property(e => e.MaSV)
                .IsUnicode(false);

            

            

            modelBuilder.Entity<LoaiTaiKhoan>()
                .Property(e => e.MaLoaiTaiKhoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiTaiKhoan>()
                .Property(e => e.TenLoaiTaiKhoan)
                .IsUnicode(false);





            modelBuilder.Entity<Toa>()
                .Property(e => e.MaToa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Truong>()
                .Property(e => e.MaTruong)
                .IsUnicode(false);


            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MaLoaiTaiKhoan)
                .IsFixedLength()
                .IsUnicode(false);

            

            
                .IsUnicode(false);

            modelBuilder.Entity<Truong>()
                .Property(e => e.MaTruong)
                .IsUnicode(false);
        }
    }
}
