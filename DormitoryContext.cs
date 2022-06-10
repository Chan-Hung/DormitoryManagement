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

        public virtual DbSet<ElectricityAndWaterBill> ElectricityAndWaterBills { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<School> Schools { get; set; }
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Configurations.StudentConfig());

            modelBuilder.Configurations.Add(new Configurations.AccountConfig());

            modelBuilder.Configurations.Add(new Configurations.BuildingConfig());

            modelBuilder.Configurations.Add(new Configurations.EmployeeTypeConfig());

            modelBuilder.Configurations.Add(new Configurations.EmployeeConfig());

            modelBuilder.Configurations.Add(new Configurations.RoomTypeConfig());

            modelBuilder.Configurations.Add(new Configurations.RoomConfig());

            modelBuilder.Configurations.Add(new Configurations.SchoolConfig());

            modelBuilder.Configurations.Add(new Configurations.ElectricityAndWaterBillConfig());     

            modelBuilder.Entity<LoaiTaiKhoan>()
                .Property(e => e.MaLoaiTaiKhoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiTaiKhoan>()
                .Property(e => e.TenLoaiTaiKhoan)
                .IsUnicode(false);
        }
    }
}
