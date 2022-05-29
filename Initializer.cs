using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DormitoryManagement
{
    public class Initializer:DropCreateDatabaseIfModelChanges<QuanLyKTXModel>
    {
        protected override void Seed(QuanLyKTXModel context)
        {
            
            //khoi tao truong
            IList<Truong> truongs = new List<Truong>();
            truongs.Add(new Truong("BKU", "Đại học Bách Khoa Thành phố Hồ chí Minh"));
            truongs.Add(new Truong("HCMUS", "Đại học Khoa học tự nhiên"));
            truongs.Add(new Truong("HUB", "Đại học Ngân hàng Thành phố Hồ Chí Minh"));
            truongs.Add(new Truong("NLU", "Đại học Nông lâm"));
            truongs.Add(new Truong("UEH", "Đại học Kinh tế Thành phố Hồ Chí Minh"));
            truongs.Add(new Truong("UIT", "Đại học Công nghệ thông tin"));
            truongs.Add(new Truong("USSH", "Đại học Khoa học Xã hội và Nhân văn"));
            truongs.Add(new Truong("UTE", "Đại học Sư phạm Kỹ thuật Thành phố Hồ Chí Minh"));
            truongs.Add(new Truong("VLU", "Đại học Văn Lang"));
            truongs.Add(new Truong("UEL", "Đại học Kinh tế - Luật"));
            context.Truongs.AddRange(truongs);


            //khởi tạo tòa
            IList<Toa> toas = new List<Toa>();
            toas.Add(new Toa("A1", 5,400,10));
            toas.Add(new Toa("A2", 5, 800, 10));
            toas.Add(new Toa("A3", 5, 600, 10));
            toas.Add(new Toa("A4", 5, 600, 10));
            toas.Add(new Toa("A5", 5, 600, 10));
            toas.Add(new Toa("A6", 5, 800, 10));
            toas.Add(new Toa("A7", 5, 600, 10));
            toas.Add(new Toa("A8", 6, 100, 7));
            context.Toas.AddRange(toas);

            //khởi tạo loại tài khoản
            IList<LoaiTaiKhoan> loaiTaiKhoans = new List<LoaiTaiKhoan>();
            loaiTaiKhoans.Add(new LoaiTaiKhoan("1", "Admin", "Quản lý chung"));
            loaiTaiKhoans.Add(new LoaiTaiKhoan("2", "Employee", "Nhân viên quản lý sinh viên và cơ sở vật chất"));
            context.LoaiTaiKhoans.AddRange(loaiTaiKhoans);

            //khởi tạo loại phòng
            IList<LoaiPhong> loaiPhongs = new List<LoaiPhong>();
            loaiPhongs.Add(new LoaiPhong("ML2", "Phòng máy lạnh 2 người", 450000));
            loaiPhongs.Add(new LoaiPhong("ML4", "Phòng máy lạnh 4 người", 350000));
            loaiPhongs.Add(new LoaiPhong("PQ4", "Phòng quạt 4 người", 300000));
            loaiPhongs.Add(new LoaiPhong("PQ8", "Phòng quạt 8 người", 250000));
            context.LoaiPhongs.AddRange(loaiPhongs);

            //Khởi tạo loại nhân viên
            IList<LoaiNhanVien> loaiNhanViens = new List<LoaiNhanVien>();
            loaiNhanViens.Add(new LoaiNhanVien("01", "Bảo vệ"));
            loaiNhanViens.Add(new LoaiNhanVien("02", "Lao công"));
            loaiNhanViens.Add(new LoaiNhanVien("03", "Đầu bếp"));
            loaiNhanViens.Add(new LoaiNhanVien("04", "Nhân viên bán hàng"));
            loaiNhanViens.Add(new LoaiNhanVien("05", "Quản lý"));
            loaiNhanViens.Add(new LoaiNhanVien("06", "Nhân viên văn phòng"));
            loaiNhanViens.Add(new LoaiNhanVien("07", "Quản trị hệ thống"));
            context.LoaiNhanViens.AddRange(loaiNhanViens);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
