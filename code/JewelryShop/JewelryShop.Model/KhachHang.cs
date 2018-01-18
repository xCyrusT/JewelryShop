namespace JewelryShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Display(Name = "Mã khách hàng")]
        public int KhachHangID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên khách hàng")]
        public string TenKhachHang { get; set; }

        [StringLength(100)]
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [StringLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(32)]
        [Display(Name = "Pass")]
        public string Pass { get; set; }

        [StringLength(15)]
        [Display(Name = "Số điện thoại")]
        public string DienThoai { get; set; }

        [StringLength(1000)]
        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; }
    }
}
