//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLVNNhaNam
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDH
    {
        public string MaDH { get; set; }
        public string MaSP { get; set; }
        public int SLDat { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
