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
    
    public partial class HopDongThuePhong
    {
        public string MaHD { get; set; }
        public string MaSV { get; set; }
        public System.DateTime NgayKHD { get; set; }
        public System.DateTime NgayKTHD { get; set; }
    
        public virtual SinhVien SinhVien { get; set; }
    }
}