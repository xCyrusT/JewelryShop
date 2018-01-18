namespace JewelryShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Display(Name = "Mã nhân viên")]
        public int NhanVienID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên nhân viên")]
        public string TenNhanVien { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(32)]
        [Display(Name = "Số điện thoại")]
        public string Pass { get; set; }

        [StringLength(100)]
        [Display(Name = "Avatar")]
        public string Avatar { get; set; }

        [Display(Name = "Trạng thái")]
        public int? TrangThai { get; set; }
    }
}
