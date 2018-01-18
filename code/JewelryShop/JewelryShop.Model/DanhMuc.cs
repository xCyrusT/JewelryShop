namespace JewelryShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMuc")]
    public partial class DanhMuc
    {
        [Display(Name = "Mã danh mục")]
        public int DanhMucID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên danh mục")]
        public string TenDanhMuc { get; set; }

        [Display(Name = "Trạng thái")]
        public int? TrangThai { get; set; }
    }
}
