namespace JewelryShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonBan")]
    public partial class HoaDonBan
    {
        [StringLength(5)]
        public string HoaDonBanID { get; set; }

        [StringLength(5)]
        public string NhanVienID { get; set; }

        [StringLength(5)]
        public string KhachHangID { get; set; }

        public double? TongTien { get; set; }

        public DateTime? NgayBan { get; set; }

        public int TrangThai { get; set; }

        public virtual ChiTietHDBan ChiTietHDBan { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
