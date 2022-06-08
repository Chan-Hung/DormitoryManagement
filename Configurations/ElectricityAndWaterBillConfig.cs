using System.Data.Entity.ModelConfiguration;


namespace DormitoryManagement.Configurations
{
    public class ElectricityAndWaterBillConfig : EntityTypeConfiguration<ElectricityAndWaterBill>
    {
        public ElectricityAndWaterBillConfig()
        {
            Property(e => e.MaHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
