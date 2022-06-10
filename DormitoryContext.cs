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
        public virtual DbSet<Contract> HopDongThuePhongs { get; set; }
        public virtual DbSet<EmployeeType> LoaiNhanViens { get; set; }
        public virtual DbSet<RoomType> LoaiPhongs { get; set; }
        public virtual DbSet<AccountType> LoaiTaiKhoans { get; set; }
        public virtual DbSet<Employee> NhanViens { get; set; }
        public virtual DbSet<Room> Phongs { get; set; }
        public virtual DbSet<Student> SinhViens { get; set; }
        public virtual DbSet<Account> TaiKhoans { get; set; }

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

            modelBuilder.Configurations.Add(new Configurations.SchoolConfig());

            modelBuilder.Configurations.Add(new Configurations.ElectricityAndWaterBillConfig());

            modelBuilder.Configurations.Add(new Configurations.AccountTypeConfig());
        }
    }
}
