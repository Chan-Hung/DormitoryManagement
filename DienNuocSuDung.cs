//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DormitoryManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class DienNuocSuDung
    {
        public string MaHoaDon { get; set; }
        public string MaPhong { get; set; }
        public System.DateTime NgayLap { get; set; }
        public int SoDienTieuThu { get; set; }
        public int SoNuocTieuthu { get; set; }
        public string TrangThai { get; set; }
    
        public virtual Phong Phong { get; set; }
    }
}