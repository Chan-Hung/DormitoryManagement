using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DormitoryManagement
{
    public class Initializer: DropCreateDatabaseIfModelChanges<DormitoryContext>
    {
        protected override void Seed(DormitoryContext context)
        {
            
            //khoi tao truong
            IList<School> truongs = new List<School>();
            truongs.Add(new School("BKU", "Đại học Bách Khoa Thành phố Hồ chí Minh"));
            truongs.Add(new School("HCMUS", "Đại học Khoa học tự nhiên"));
            truongs.Add(new School("HUB", "Đại học Ngân hàng Thành phố Hồ Chí Minh"));
            truongs.Add(new School("NLU", "Đại học Nông lâm"));
            truongs.Add(new School("UEH", "Đại học Kinh tế Thành phố Hồ Chí Minh"));
            truongs.Add(new School("UIT", "Đại học Công nghệ thông tin"));
            truongs.Add(new School("USSH", "Đại học Khoa học Xã hội và Nhân văn"));
            truongs.Add(new School("UTE", "Đại học Sư phạm Kỹ thuật Thành phố Hồ Chí Minh"));
            truongs.Add(new School("VLU", "Đại học Văn Lang"));
            truongs.Add(new School("UEL", "Đại học Kinh tế - Luật"));
            context.Truongs.AddRange(truongs);


            //khởi tạo tòa
            IList<Building> toas = new List<Building>();
            toas.Add(new Building("A1", 5,400,10));
            toas.Add(new Building("A2", 5, 800, 10));
            toas.Add(new Building("A3", 5, 600, 10));
            toas.Add(new Building("A4", 5, 600, 10));
            toas.Add(new Building("A5", 5, 600, 10));
            toas.Add(new Building("A6", 5, 800, 10));
            toas.Add(new Building("A7", 5, 600, 10));
            toas.Add(new Building("A8", 6, 100, 7));
            context.Toas.AddRange(toas);

            //khởi tạo loại tài khoản
            IList<LoaiTaiKhoan> loaiTaiKhoans = new List<LoaiTaiKhoan>();
            loaiTaiKhoans.Add(new LoaiTaiKhoan("1", "Admin", "Quản lý chung"));
            loaiTaiKhoans.Add(new LoaiTaiKhoan("2", "Employee", "Nhân viên quản lý sinh viên và cơ sở vật chất"));
            context.LoaiTaiKhoans.AddRange(loaiTaiKhoans);

            //khởi tạo loại phòng
            IList<RoomType> loaiPhongs = new List<RoomType>();
            loaiPhongs.Add(new RoomType("ML2", "Phòng máy lạnh 2 người", 450000));
            loaiPhongs.Add(new RoomType("ML4", "Phòng máy lạnh 4 người", 350000));
            loaiPhongs.Add(new RoomType("PQ4", "Phòng quạt 4 người", 300000));
            loaiPhongs.Add(new RoomType("PQ8", "Phòng quạt 8 người", 250000));
            context.LoaiPhongs.AddRange(loaiPhongs);

            //Khởi tạo loại nhân viên
            IList<EmployeeType> loaiNhanViens = new List<EmployeeType>();
            loaiNhanViens.Add(new EmployeeType("01", "Bảo vệ"));
            loaiNhanViens.Add(new EmployeeType("02", "Lao công"));
            loaiNhanViens.Add(new EmployeeType("03", "Đầu bếp"));
            loaiNhanViens.Add(new EmployeeType("04", "Nhân viên bán hàng"));
            loaiNhanViens.Add(new EmployeeType("05", "Quản lý"));
            loaiNhanViens.Add(new EmployeeType("06", "Nhân viên văn phòng"));
            loaiNhanViens.Add(new EmployeeType("07", "Quản trị hệ thống"));
            context.LoaiNhanViens.AddRange(loaiNhanViens);


            //khởi tạo phòng
            IList<Room> phongs = new List<Room>();
            phongs.Add(new Room("001",toas[0].MaToa, loaiPhongs[2].MaLoaiPhong, "Còn"));
            phongs.Add(new Room("002",toas[1].MaToa, loaiPhongs[1].MaLoaiPhong, "Còn"));
            phongs.Add(new Room("003",toas[2].MaToa, loaiPhongs[0].MaLoaiPhong, "Còn"));
            phongs.Add(new Room("004",toas[3].MaToa, loaiPhongs[3].MaLoaiPhong, "Còn"));
            phongs.Add(new Room("011",toas[0].MaToa, loaiPhongs[2].MaLoaiPhong, "Còn"));
            phongs.Add(new Room("012",toas[1].MaToa, loaiPhongs[1].MaLoaiPhong, "Còn"));
            phongs.Add(new Room("013",toas[2].MaToa, loaiPhongs[1].MaLoaiPhong, "Còn"));
            phongs.Add(new Room("014",toas[3].MaToa, loaiPhongs[3].MaLoaiPhong, "Còn"));
            phongs.Add(new Room("021",toas[0].MaToa, loaiPhongs[1].MaLoaiPhong, "Còn"));
            phongs.Add(new Room("022",toas[1].MaToa, loaiPhongs[2].MaLoaiPhong, "Còn"));
            context.Phongs.AddRange(phongs);


            //khởi tạo Nhân Viên
            IList<Employee> nhanViens = new List<Employee>();
            nhanViens.Add(new Employee("BH11", loaiNhanViens[3].MaLoaiNV, toas[0].MaToa, "Lưu Thùy Điên", "0956248635", 123465));
            nhanViens.Add(new Employee("BH13", loaiNhanViens[3].MaLoaiNV, toas[0].MaToa, "Tăng Trường Phúc", "0766612564", 4000000));
            nhanViens.Add(new Employee("BH21", loaiNhanViens[3].MaLoaiNV, toas[1].MaToa, "Lê Thành Long", "0999564128", 4000000));
            nhanViens.Add(new Employee("BH22", loaiNhanViens[3].MaLoaiNV, toas[1].MaToa, "Sơn Huy Thành", "0799164512", 4000000));
            nhanViens.Add(new Employee("BH23", loaiNhanViens[3].MaLoaiNV, toas[1].MaToa, "Bì Hữu Trung", "0777653147", 4000000));
            nhanViens.Add(new Employee("BH31", loaiNhanViens[3].MaLoaiNV, toas[2].MaToa, "Thành Bích Hà", "0787332168", 4000000));
            nhanViens.Add(new Employee("BH32", loaiNhanViens[3].MaLoaiNV, toas[2].MaToa, "Lục Tuyết Hân", "0792108736", 4000000));
            nhanViens.Add(new Employee("BH33", loaiNhanViens[3].MaLoaiNV, toas[2].MaToa, "Châu Ngọc Lân", "0777712554", 4000000));
            nhanViens.Add(new Employee("BH41", loaiNhanViens[3].MaLoaiNV, toas[3].MaToa, "Mai Ngân Thanh", "0771121121", 4000000));
            nhanViens.Add(new Employee("BH42", loaiNhanViens[3].MaLoaiNV, toas[3].MaToa, "Duy Minh Huệ", "0777777111", 4000000));
            nhanViens.Add(new Employee("BH43", loaiNhanViens[3].MaLoaiNV, toas[3].MaToa, "Văn Thủy Tâm", "0309499599", 4000000));

            nhanViens.Add(new Employee("BV11", loaiNhanViens[0].MaLoaiNV, toas[0].MaToa, "Trần Mạnh Vũ", "0905671234", 5000000));
            nhanViens.Add(new Employee("BV12", loaiNhanViens[0].MaLoaiNV, toas[0].MaToa, "Đặng Tuấn Linh", "0358848976", 5000000));
            nhanViens.Add(new Employee("BV21", loaiNhanViens[0].MaLoaiNV, toas[1].MaToa, "Võ Khánh An", "0941325978", 5000000));
            nhanViens.Add(new Employee("BV22", loaiNhanViens[0].MaLoaiNV, toas[1].MaToa, "Vương Ðình Hảo", "0356831549", 5000000));
            nhanViens.Add(new Employee("BV31", loaiNhanViens[0].MaLoaiNV, toas[2].MaToa, "Tạ Ðức Giang", "0948512348", 5000000));
            nhanViens.Add(new Employee("BV32", loaiNhanViens[0].MaLoaiNV, toas[2].MaToa, "Trần Việt Khôi", "0789312358", 5000000));
            nhanViens.Add(new Employee("BV41", loaiNhanViens[0].MaLoaiNV, toas[3].MaToa, "Đức Quang Hải", "0933156876", 5000000));
            nhanViens.Add(new Employee("BV42", loaiNhanViens[0].MaLoaiNV, toas[3].MaToa, "Thục Quang Minh", "0333456878", 5000000));



            nhanViens.Add(new Employee("DB11", loaiNhanViens[2].MaLoaiNV, toas[0].MaToa, "Nguyễn Ðức Hải", "0898315498", 6000000));
            nhanViens.Add(new Employee("DB12", loaiNhanViens[2].MaLoaiNV, toas[0].MaToa, "Hồ Minh Trung", "0333158621", 6000000));
            nhanViens.Add(new Employee("DB21", loaiNhanViens[2].MaLoaiNV, toas[1].MaToa, "Lâm Quang Triều", "0878991234", 6000000));
            nhanViens.Add(new Employee("DB22", loaiNhanViens[2].MaLoaiNV, toas[1].MaToa, "Hán Minh Tuấn", "0334913646", 6000000));
            nhanViens.Add(new Employee("DB31", loaiNhanViens[2].MaLoaiNV, toas[2].MaToa, "Giao Tịnh Như", "0920025941", 6000000));
            nhanViens.Add(new Employee("DB32", loaiNhanViens[2].MaLoaiNV, toas[2].MaToa, "Điêu Linh Lan", "0989222213", 6000000));
            nhanViens.Add(new Employee("DB41", loaiNhanViens[2].MaLoaiNV, toas[3].MaToa, "Trang Anh Thi", "0897864222", 6000000));
            nhanViens.Add(new Employee("DB42", loaiNhanViens[2].MaLoaiNV, toas[3].MaToa, "Dương Hồng Quế", "0320034685", 6000000));

            nhanViens.Add(new Employee("LC11", loaiNhanViens[1].MaLoaiNV, toas[0].MaToa, "Đặng Thị Tú Quyên", "0948389184", 4500000));
            nhanViens.Add(new Employee("LC12", loaiNhanViens[1].MaLoaiNV, toas[0].MaToa, "Lý Kim Chi", "0948389184", 4500000));
            nhanViens.Add(new Employee("LC21", loaiNhanViens[1].MaLoaiNV, toas[1].MaToa, "Diêm Hồng Thúy", "0333158971", 4500000));
            nhanViens.Add(new Employee("LC22", loaiNhanViens[1].MaLoaiNV, toas[1].MaToa, "Đào Mai Châu", "0935486782", 4500000));
            nhanViens.Add(new Employee("LC31", loaiNhanViens[1].MaLoaiNV, toas[2].MaToa, "Trưng Thế Minh", "0791356972", 4500000));
            nhanViens.Add(new Employee("LC32", loaiNhanViens[1].MaLoaiNV, toas[2].MaToa, "Trương Ðình Toàn", "0946333158", 4500000));
            nhanViens.Add(new Employee("LC41", loaiNhanViens[1].MaLoaiNV, toas[3].MaToa, "Mai Quốc Hùng", "0988464111", 4500000));
            nhanViens.Add(new Employee("LC42", loaiNhanViens[1].MaLoaiNV, toas[3].MaToa, "Lý Thế Doanh", "0936689994", 4500000));

            nhanViens.Add(new Employee("QL11", loaiNhanViens[4].MaLoaiNV, toas[0].MaToa, "Trần Quang Hải", "0991012364", 7000000));
            nhanViens.Add(new Employee("QL12", loaiNhanViens[4].MaLoaiNV, toas[0].MaToa, "Trần Tuấn Việt", "0912358768", 7000000));
            nhanViens.Add(new Employee("QL21", loaiNhanViens[4].MaLoaiNV, toas[1].MaToa, "Ngô Xuân Trung", "0303489185", 7000000));
            nhanViens.Add(new Employee("QL22", loaiNhanViens[4].MaLoaiNV, toas[1].MaToa, "Đoàn Huy Khánh", "0923111592", 7000000));
            nhanViens.Add(new Employee("QL31", loaiNhanViens[4].MaLoaiNV, toas[2].MaToa, "Đăng Minh Tú", "0991223485", 7000000));
            nhanViens.Add(new Employee("QL32", loaiNhanViens[4].MaLoaiNV, toas[2].MaToa, "Đan Cảnh Tuấn", "0948565131", 7000000));
            nhanViens.Add(new Employee("QL41", loaiNhanViens[4].MaLoaiNV, toas[3].MaToa, "Ngũ Khánh Hà", "0909999111", 7000000));
            nhanViens.Add(new Employee("QL42", loaiNhanViens[4].MaLoaiNV, toas[3].MaToa, "Lý Trọng Hiếu", "0933115554", 7000000));

            nhanViens.Add(new Employee("QT01", loaiNhanViens[6].MaLoaiNV, toas[0].MaToa, "NP", "", 40000000));


            nhanViens.Add(new Employee("VP11", loaiNhanViens[5].MaLoaiNV, toas[0].MaToa, "Trần Bảo Hân", "0715862431", 5500000));
            nhanViens.Add(new Employee("VP12", loaiNhanViens[5].MaLoaiNV, toas[0].MaToa, "Diệp Bích Quyên", "0777321564", 5500000));
            nhanViens.Add(new Employee("VP21", loaiNhanViens[5].MaLoaiNV, toas[1].MaToa, "Lưu Ðức Phú", "0333125975", 5500000));
            nhanViens.Add(new Employee("VP22", loaiNhanViens[5].MaLoaiNV, toas[1].MaToa, "Tôn Lan Phương", "0755648186", 5500000));
            nhanViens.Add(new Employee("VP31", loaiNhanViens[5].MaLoaiNV, toas[2].MaToa, "Vũ Hảo Nhi", "0788113456", 5500000));
            nhanViens.Add(new Employee("VP32", loaiNhanViens[5].MaLoaiNV, toas[2].MaToa, "Tạ Minh Chiến", "0309945125", 5500000));
            nhanViens.Add(new Employee("VP41", loaiNhanViens[5].MaLoaiNV, toas[3].MaToa, "Đồng Trung Anh", "0700315648", 5500000));
            nhanViens.Add(new Employee("VP42", loaiNhanViens[5].MaLoaiNV, toas[3].MaToa, "Nhâm Vĩnh Hưng", "0766445221", 5500000));

            context.NhanViens.AddRange(nhanViens);

            //Khởi tạo tài khoản
            IList<Account> taiKhoans = new List<Account>();
            taiKhoans.Add(new Account(nhanViens[47].MaNV, "emp1", "@emp1", loaiTaiKhoans[1].MaLoaiTaiKhoan));
            taiKhoans.Add(new Account(nhanViens[46].MaNV, "admin1", "@admin1", loaiTaiKhoans[0].MaLoaiTaiKhoan));
            taiKhoans.Add(new Account(nhanViens[48].MaNV, "emp2", "@emp2", loaiTaiKhoans[1].MaLoaiTaiKhoan));
            context.TaiKhoans.AddRange(taiKhoans);

            //Khởi tạo danh sách sinh viên

            IList<Student> sinhViens = new List<Student>();
            sinhViens.Add(new Student("11950527", "Phạm An Hạ", "F", "0768212654", truongs[4].MaTruong, phongs[2].MaPhong));
            sinhViens.Add(new Student("20110031", "Hoàng Minh Long", "M", "0798312687", truongs[9].MaTruong, phongs[1].MaPhong));
            sinhViens.Add(new Student("19941297", "Châu Thành Long", "M", "0955514031", truongs[8].MaTruong, phongs[3].MaPhong));
            sinhViens.Add(new Student("30150404", "Phạm Xuân Hương", "F", "0361334887", truongs[4].MaTruong, phongs[6].MaPhong));
            sinhViens.Add(new Student("66937210", "Trương Khắc Tuấn", "M", "0952135797", truongs[8].MaTruong, phongs[3].MaPhong));
            sinhViens.Add(new Student("49495277", "Thái Tuyết Hương", "F", "096125879 ", truongs[4].MaTruong, phongs[6].MaPhong));
            sinhViens.Add(new Student("40219226", "Lục Quang Đông", "M", "0304846879", truongs[8].MaTruong, phongs[3].MaPhong));
            sinhViens.Add(new Student("96112364", "Bành Thái Duy", "M", "0741324697", truongs[8].MaTruong, phongs[3].MaPhong));
            sinhViens.Add(new Student("20687487", "Võ Hoàng Long", "M", "0769978564", truongs[9].MaTruong, phongs[1].MaPhong));
            context.SinhViens.AddRange(sinhViens);

            

            //Khởi tạo điện nước tiêu thụ
            IList<ElectricityAndWaterBill> dienNuocSuDungs = new List<ElectricityAndWaterBill>();
            dienNuocSuDungs.Add(new ElectricityAndWaterBill("001", phongs[6].MaPhong,DateTime.Parse("2022,01,05"),131,17,"Chưa thanh toán"));
            dienNuocSuDungs.Add(new ElectricityAndWaterBill("002", phongs[1].MaPhong,DateTime.Parse("2022,01,05"),70,13,"Chưa thanh toán"));
            dienNuocSuDungs.Add(new ElectricityAndWaterBill("003", phongs[3].MaPhong,DateTime.Parse("2022,01,05"),68,14,"Chưa thanh toán"));
            context.DienNuocSuDungs.AddRange(dienNuocSuDungs);

            //Khởi tạo hợp đồng
            IList<Contract> hopDongThuePhongs = new List<Contract>();
            hopDongThuePhongs.Add(new Contract("0001", "11950527",DateTime.Now, DateTime.Now.AddYears(1)));
            hopDongThuePhongs.Add(new Contract("0002", "20110031", DateTime.Now, DateTime.Now.AddYears(1)));
            hopDongThuePhongs.Add(new Contract("0003", "19941297", DateTime.Now, DateTime.Now.AddYears(1)));
            hopDongThuePhongs.Add(new Contract("0004", "30150404", DateTime.Now, DateTime.Now.AddYears(1)));
            hopDongThuePhongs.Add(new Contract("0005", "66937210", DateTime.Now, DateTime.Now.AddYears(1)));
            hopDongThuePhongs.Add(new Contract("0006", "49495277", DateTime.Now, DateTime.Now.AddYears(1)));
            hopDongThuePhongs.Add(new Contract("0007", "40219226", DateTime.Now, DateTime.Now.AddYears(1)));
            hopDongThuePhongs.Add(new Contract("0008", "96112364", DateTime.Now, DateTime.Now.AddYears(1)));
            hopDongThuePhongs.Add(new Contract("0009", "20687487", DateTime.Now, DateTime.Now.AddYears(1)));
            context.HopDongThuePhongs.AddRange(hopDongThuePhongs);


            context.SaveChanges();
            base.Seed(context);
        }
    }
}
