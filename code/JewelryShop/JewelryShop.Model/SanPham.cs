namespace JewelryShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Display(Name = "Mã sản phẩm")]
        public int SanPhamID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên sản phẩm")]
        public string TenSanPham { get; set; }

        [Display(Name = "Giá")]
        public double? DonGia { get; set; }

        [StringLength(10)]
        [Display(Name = "Đơn vị tính")]
        public string DonViTinh { get; set; }

        [StringLength(100)]
        [Display(Name = "Hình ảnh")]
        public string Anh { get; set; }

        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }

        [Column(TypeName = "smalldatetime")]
        [Display(Name = "Ngày cập nhật")]
        public DateTime? NgayCapNhat { get; set; }

        [Display(Name = "Danh mục")]
        public int? DanhMucID { get; set; }

        [Display(Name = "Số lượng bán")]
        public int? SoLuongBan { get; set; }

        [Display(Name = "Trạng thái")]
        public int? TrangThai { get; set; }
    }
}
