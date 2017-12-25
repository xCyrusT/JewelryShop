namespace JewelryShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHDBan")]
    public partial class ChiTietHDBan
    {
        [Key]
        [StringLength(5)]
        public string HoaDonBanID { get; set; }

        [StringLength(5)]
        public string SanPhamID { get; set; }

        public double? DonGia { get; set; }

        public int? SoLuong { get; set; }

        public double? GiamGia { get; set; }

        public double? ThanhTien { get; set; }

        public virtual HoaDonBan HoaDonBan { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
