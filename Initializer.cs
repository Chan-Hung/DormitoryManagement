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
            IList<School> schools = new List<School>();
            schools.Add(new School("BKU", "Đại học Bách Khoa Thành phố Hồ chí Minh"));
            schools.Add(new School("HCMUS", "Đại học Khoa học tự nhiên"));
            schools.Add(new School("HUB", "Đại học Ngân hàng Thành phố Hồ Chí Minh"));
            schools.Add(new School("NLU", "Đại học Nông lâm"));
            schools.Add(new School("UEH", "Đại học Kinh tế Thành phố Hồ Chí Minh"));
            schools.Add(new School("UIT", "Đại học Công nghệ thông tin"));
            schools.Add(new School("USSH", "Đại học Khoa học Xã hội và Nhân văn"));
            schools.Add(new School("UTE", "Đại học Sư phạm Kỹ thuật Thành phố Hồ Chí Minh"));
            schools.Add(new School("VLU", "Đại học Văn Lang"));
            schools.Add(new School("UEL", "Đại học Kinh tế - Luật"));
            context.Schools.AddRange(schools);


            //khởi tạo tòa
            IList<Building> buildings = new List<Building>();
            buildings.Add(new Building("A1", 5,400,10));
            buildings.Add(new Building("A2", 5, 800, 10));
            buildings.Add(new Building("A3", 5, 600, 10));
            buildings.Add(new Building("A4", 5, 600, 10));
            buildings.Add(new Building("A5", 5, 600, 10));
            buildings.Add(new Building("A6", 5, 800, 10));
            buildings.Add(new Building("A7", 5, 600, 10));
            buildings.Add(new Building("A8", 6, 100, 7));
            context.Buildings.AddRange(buildings);

            //khởi tạo loại tài khoản
            IList<LoaiTaiKhoan> loaiTaiKhoans = new List<LoaiTaiKhoan>();
            loaiTaiKhoans.Add(new LoaiTaiKhoan("1", "Admin", "Quản lý chung"));
            loaiTaiKhoans.Add(new LoaiTaiKhoan("2", "Employee", "Nhân viên quản lý sinh viên và cơ sở vật chất"));
            context.LoaiTaiKhoans.AddRange(loaiTaiKhoans);

            //khởi tạo loại phòng
            IList<RoomType> roomTypes = new List<RoomType>();
            roomTypes.Add(new RoomType("ML2", "Phòng máy lạnh 2 người", 450000));
            roomTypes.Add(new RoomType("ML4", "Phòng máy lạnh 4 người", 350000));
            roomTypes.Add(new RoomType("PQ4", "Phòng quạt 4 người", 300000));
            roomTypes.Add(new RoomType("PQ8", "Phòng quạt 8 người", 250000));
            context.RoomTypes.AddRange(roomTypes);

            //Khởi tạo loại nhân viên
            IList<EmployeeType> employeeTypes = new List<EmployeeType>();
            employeeTypes.Add(new EmployeeType("01", "Bảo vệ"));
            employeeTypes.Add(new EmployeeType("02", "Lao công"));
            employeeTypes.Add(new EmployeeType("03", "Đầu bếp"));
            employeeTypes.Add(new EmployeeType("04", "Nhân viên bán hàng"));
            employeeTypes.Add(new EmployeeType("05", "Quản lý"));
            employeeTypes.Add(new EmployeeType("06", "Nhân viên văn phòng"));
            employeeTypes.Add(new EmployeeType("07", "Quản trị hệ thống"));
            context.EmployeeTypes.AddRange(employeeTypes);


            //khởi tạo phòng
            IList<Room> rooms = new List<Room>();
            rooms.Add(new Room("001",buildings[0].MaToa, roomTypes[2].MaLoaiPhong, "Còn"));
            rooms.Add(new Room("002",buildings[1].MaToa, roomTypes[1].MaLoaiPhong, "Còn"));
            rooms.Add(new Room("003",buildings[2].MaToa, roomTypes[0].MaLoaiPhong, "Còn"));
            rooms.Add(new Room("004",buildings[3].MaToa, roomTypes[3].MaLoaiPhong, "Còn"));
            rooms.Add(new Room("011",buildings[0].MaToa, roomTypes[2].MaLoaiPhong, "Còn"));
            rooms.Add(new Room("012",buildings[1].MaToa, roomTypes[1].MaLoaiPhong, "Còn"));
            rooms.Add(new Room("013",buildings[2].MaToa, roomTypes[1].MaLoaiPhong, "Còn"));
            rooms.Add(new Room("014",buildings[3].MaToa, roomTypes[3].MaLoaiPhong, "Còn"));
            rooms.Add(new Room("021",buildings[0].MaToa, roomTypes[1].MaLoaiPhong, "Còn"));
            rooms.Add(new Room("022",buildings[1].MaToa, roomTypes[2].MaLoaiPhong, "Còn"));
            context.Rooms.AddRange(rooms);


            //khởi tạo Nhân Viên
            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee("BH11", employeeTypes[3].MaLoaiNV, buildings[0].MaToa, "Lưu Thùy Điên", "0956248635", 123465));
            employees.Add(new Employee("BH13", employeeTypes[3].MaLoaiNV, buildings[0].MaToa, "Tăng Trường Phúc", "0766612564", 4000000));
            employees.Add(new Employee("BH21", employeeTypes[3].MaLoaiNV, buildings[1].MaToa, "Lê Thành Long", "0999564128", 4000000));
            employees.Add(new Employee("BH22", employeeTypes[3].MaLoaiNV, buildings[1].MaToa, "Sơn Huy Thành", "0799164512", 4000000));
            employees.Add(new Employee("BH23", employeeTypes[3].MaLoaiNV, buildings[1].MaToa, "Bì Hữu Trung", "0777653147", 4000000));
            employees.Add(new Employee("BH31", employeeTypes[3].MaLoaiNV, buildings[2].MaToa, "Thành Bích Hà", "0787332168", 4000000));
            employees.Add(new Employee("BH32", employeeTypes[3].MaLoaiNV, buildings[2].MaToa, "Lục Tuyết Hân", "0792108736", 4000000));
            employees.Add(new Employee("BH33", employeeTypes[3].MaLoaiNV, buildings[2].MaToa, "Châu Ngọc Lân", "0777712554", 4000000));
            employees.Add(new Employee("BH41", employeeTypes[3].MaLoaiNV, buildings[3].MaToa, "Mai Ngân Thanh", "0771121121", 4000000));
            employees.Add(new Employee("BH42", employeeTypes[3].MaLoaiNV, buildings[3].MaToa, "Duy Minh Huệ", "0777777111", 4000000));
            employees.Add(new Employee("BH43", employeeTypes[3].MaLoaiNV, buildings[3].MaToa, "Văn Thủy Tâm", "0309499599", 4000000));

            employees.Add(new Employee("BV11", employeeTypes[0].MaLoaiNV, buildings[0].MaToa, "Trần Mạnh Vũ", "0905671234", 5000000));
            employees.Add(new Employee("BV12", employeeTypes[0].MaLoaiNV, buildings[0].MaToa, "Đặng Tuấn Linh", "0358848976", 5000000));
            employees.Add(new Employee("BV21", employeeTypes[0].MaLoaiNV, buildings[1].MaToa, "Võ Khánh An", "0941325978", 5000000));
            employees.Add(new Employee("BV22", employeeTypes[0].MaLoaiNV, buildings[1].MaToa, "Vương Ðình Hảo", "0356831549", 5000000));
            employees.Add(new Employee("BV31", employeeTypes[0].MaLoaiNV, buildings[2].MaToa, "Tạ Ðức Giang", "0948512348", 5000000));
            employees.Add(new Employee("BV32", employeeTypes[0].MaLoaiNV, buildings[2].MaToa, "Trần Việt Khôi", "0789312358", 5000000));
            employees.Add(new Employee("BV41", employeeTypes[0].MaLoaiNV, buildings[3].MaToa, "Đức Quang Hải", "0933156876", 5000000));
            employees.Add(new Employee("BV42", employeeTypes[0].MaLoaiNV, buildings[3].MaToa, "Thục Quang Minh", "0333456878", 5000000));



            employees.Add(new Employee("DB11", employeeTypes[2].MaLoaiNV, buildings[0].MaToa, "Nguyễn Ðức Hải", "0898315498", 6000000));
            employees.Add(new Employee("DB12", employeeTypes[2].MaLoaiNV, buildings[0].MaToa, "Hồ Minh Trung", "0333158621", 6000000));
            employees.Add(new Employee("DB21", employeeTypes[2].MaLoaiNV, buildings[1].MaToa, "Lâm Quang Triều", "0878991234", 6000000));
            employees.Add(new Employee("DB22", employeeTypes[2].MaLoaiNV, buildings[1].MaToa, "Hán Minh Tuấn", "0334913646", 6000000));
            employees.Add(new Employee("DB31", employeeTypes[2].MaLoaiNV, buildings[2].MaToa, "Giao Tịnh Như", "0920025941", 6000000));
            employees.Add(new Employee("DB32", employeeTypes[2].MaLoaiNV, buildings[2].MaToa, "Điêu Linh Lan", "0989222213", 6000000));
            employees.Add(new Employee("DB41", employeeTypes[2].MaLoaiNV, buildings[3].MaToa, "Trang Anh Thi", "0897864222", 6000000));
            employees.Add(new Employee("DB42", employeeTypes[2].MaLoaiNV, buildings[3].MaToa, "Dương Hồng Quế", "0320034685", 6000000));

            employees.Add(new Employee("LC11", employeeTypes[1].MaLoaiNV, buildings[0].MaToa, "Đặng Thị Tú Quyên", "0948389184", 4500000));
            employees.Add(new Employee("LC12", employeeTypes[1].MaLoaiNV, buildings[0].MaToa, "Lý Kim Chi", "0948389184", 4500000));
            employees.Add(new Employee("LC21", employeeTypes[1].MaLoaiNV, buildings[1].MaToa, "Diêm Hồng Thúy", "0333158971", 4500000));
            employees.Add(new Employee("LC22", employeeTypes[1].MaLoaiNV, buildings[1].MaToa, "Đào Mai Châu", "0935486782", 4500000));
            employees.Add(new Employee("LC31", employeeTypes[1].MaLoaiNV, buildings[2].MaToa, "Trưng Thế Minh", "0791356972", 4500000));
            employees.Add(new Employee("LC32", employeeTypes[1].MaLoaiNV, buildings[2].MaToa, "Trương Ðình Toàn", "0946333158", 4500000));
            employees.Add(new Employee("LC41", employeeTypes[1].MaLoaiNV, buildings[3].MaToa, "Mai Quốc Hùng", "0988464111", 4500000));
            employees.Add(new Employee("LC42", employeeTypes[1].MaLoaiNV, buildings[3].MaToa, "Lý Thế Doanh", "0936689994", 4500000));

            employees.Add(new Employee("QL11", employeeTypes[4].MaLoaiNV, buildings[0].MaToa, "Trần Quang Hải", "0991012364", 7000000));
            employees.Add(new Employee("QL12", employeeTypes[4].MaLoaiNV, buildings[0].MaToa, "Trần Tuấn Việt", "0912358768", 7000000));
            employees.Add(new Employee("QL21", employeeTypes[4].MaLoaiNV, buildings[1].MaToa, "Ngô Xuân Trung", "0303489185", 7000000));
            employees.Add(new Employee("QL22", employeeTypes[4].MaLoaiNV, buildings[1].MaToa, "Đoàn Huy Khánh", "0923111592", 7000000));
            employees.Add(new Employee("QL31", employeeTypes[4].MaLoaiNV, buildings[2].MaToa, "Đăng Minh Tú", "0991223485", 7000000));
            employees.Add(new Employee("QL32", employeeTypes[4].MaLoaiNV, buildings[2].MaToa, "Đan Cảnh Tuấn", "0948565131", 7000000));
            employees.Add(new Employee("QL41", employeeTypes[4].MaLoaiNV, buildings[3].MaToa, "Ngũ Khánh Hà", "0909999111", 7000000));
            employees.Add(new Employee("QL42", employeeTypes[4].MaLoaiNV, buildings[3].MaToa, "Lý Trọng Hiếu", "0933115554", 7000000));

            employees.Add(new Employee("QT01", employeeTypes[6].MaLoaiNV, buildings[0].MaToa, "NP", "", 40000000));


            employees.Add(new Employee("VP11", employeeTypes[5].MaLoaiNV, buildings[0].MaToa, "Trần Bảo Hân", "0715862431", 5500000));
            employees.Add(new Employee("VP12", employeeTypes[5].MaLoaiNV, buildings[0].MaToa, "Diệp Bích Quyên", "0777321564", 5500000));
            employees.Add(new Employee("VP21", employeeTypes[5].MaLoaiNV, buildings[1].MaToa, "Lưu Ðức Phú", "0333125975", 5500000));
            employees.Add(new Employee("VP22", employeeTypes[5].MaLoaiNV, buildings[1].MaToa, "Tôn Lan Phương", "0755648186", 5500000));
            employees.Add(new Employee("VP31", employeeTypes[5].MaLoaiNV, buildings[2].MaToa, "Vũ Hảo Nhi", "0788113456", 5500000));
            employees.Add(new Employee("VP32", employeeTypes[5].MaLoaiNV, buildings[2].MaToa, "Tạ Minh Chiến", "0309945125", 5500000));
            employees.Add(new Employee("VP41", employeeTypes[5].MaLoaiNV, buildings[3].MaToa, "Đồng Trung Anh", "0700315648", 5500000));
            employees.Add(new Employee("VP42", employeeTypes[5].MaLoaiNV, buildings[3].MaToa, "Nhâm Vĩnh Hưng", "0766445221", 5500000));

            context.Employees.AddRange(employees);

            //Khởi tạo tài khoản
            IList<Account> accounts = new List<Account>();
            accounts.Add(new Account(employees[47].MaNV, "emp1", "@emp1", loaiTaiKhoans[1].MaLoaiTaiKhoan));
            accounts.Add(new Account(employees[46].MaNV, "admin1", "@admin1", loaiTaiKhoans[0].MaLoaiTaiKhoan));
            accounts.Add(new Account(employees[48].MaNV, "emp2", "@emp2", loaiTaiKhoans[1].MaLoaiTaiKhoan));
            context.Accounts.AddRange(accounts);

            //Khởi tạo danh sách sinh viên

            IList<Student> students = new List<Student>();
            students.Add(new Student("11950527", "Phạm An Hạ", "F", "0768212654", schools[4].MaTruong, rooms[2].MaPhong));
            students.Add(new Student("20110031", "Hoàng Minh Long", "M", "0798312687", schools[9].MaTruong, rooms[1].MaPhong));
            students.Add(new Student("19941297", "Châu Thành Long", "M", "0955514031", schools[8].MaTruong, rooms[3].MaPhong));
            students.Add(new Student("30150404", "Phạm Xuân Hương", "F", "0361334887", schools[4].MaTruong, rooms[6].MaPhong));
            students.Add(new Student("66937210", "Trương Khắc Tuấn", "M", "0952135797", schools[8].MaTruong, rooms[3].MaPhong));
            students.Add(new Student("49495277", "Thái Tuyết Hương", "F", "096125879 ", schools[4].MaTruong, rooms[6].MaPhong));
            students.Add(new Student("40219226", "Lục Quang Đông", "M", "0304846879", schools[8].MaTruong, rooms[3].MaPhong));
            students.Add(new Student("96112364", "Bành Thái Duy", "M", "0741324697", schools[8].MaTruong, rooms[3].MaPhong));
            students.Add(new Student("20687487", "Võ Hoàng Long", "M", "0769978564", schools[9].MaTruong, rooms[1].MaPhong));
            context.Students.AddRange(students);

            

            //Khởi tạo điện nước tiêu thụ
            IList<ElectricityAndWaterBill> electricityAndWaterBills = new List<ElectricityAndWaterBill>();
            electricityAndWaterBills.Add(new ElectricityAndWaterBill("001", rooms[6].MaPhong,DateTime.Parse("2022,01,05"),131,17,"Chưa thanh toán"));
            electricityAndWaterBills.Add(new ElectricityAndWaterBill("002", rooms[1].MaPhong,DateTime.Parse("2022,01,05"),70,13,"Chưa thanh toán"));
            electricityAndWaterBills.Add(new ElectricityAndWaterBill("003", rooms[3].MaPhong,DateTime.Parse("2022,01,05"),68,14,"Chưa thanh toán"));
            context.ElectricityAndWaterBills.AddRange(electricityAndWaterBills);

            //Khởi tạo hợp đồng
            IList<Contract> contracts = new List<Contract>();
            contracts.Add(new Contract("0001", "11950527",DateTime.Now, DateTime.Now.AddYears(1)));
            contracts.Add(new Contract("0002", "20110031", DateTime.Now, DateTime.Now.AddYears(1)));
            contracts.Add(new Contract("0003", "19941297", DateTime.Now, DateTime.Now.AddYears(1)));
            contracts.Add(new Contract("0004", "30150404", DateTime.Now, DateTime.Now.AddYears(1)));
            contracts.Add(new Contract("0005", "66937210", DateTime.Now, DateTime.Now.AddYears(1)));
            contracts.Add(new Contract("0006", "49495277", DateTime.Now, DateTime.Now.AddYears(1)));
            contracts.Add(new Contract("0007", "40219226", DateTime.Now, DateTime.Now.AddYears(1)));
            contracts.Add(new Contract("0008", "96112364", DateTime.Now, DateTime.Now.AddYears(1)));
            contracts.Add(new Contract("0009", "20687487", DateTime.Now, DateTime.Now.AddYears(1)));
            context.Contracts.AddRange(contracts);


            context.SaveChanges();
            base.Seed(context);
        }
    }
}
