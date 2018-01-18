namespace JewelryShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Display(Name = "Mã hoá đơn")]
        public int HoaDonID { get; set; }

        [Display(Name = "Mã khách hàng")]
        public int? KhachHangID { get; set; }

        [Column(TypeName = "smalldatetime")]
        [Display(Name = "Ngày đặt hàng")]
        public DateTime? NgayDatHang { get; set; }

        [Column(TypeName = "smalldatetime")]
        [Display(Name = "Ngày giao hàng")]
        public DateTime? NgayGiaoHang { get; set; }

        [StringLength(50)]
        [Display(Name = "Người nhận")]
        public string NguoiNhan { get; set; }

        [StringLength(100)]
        [Display(Name = "Địa chỉ")]
        public string DiaChiNhan { get; set; }

        [StringLength(20)]
        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }

        [Display(Name = "Tổng tiền")]
        public double? TongTien { get; set; }

        [Display(Name = "Trạng thái")]
        public int TrangThai { get; set; }
    }
}
