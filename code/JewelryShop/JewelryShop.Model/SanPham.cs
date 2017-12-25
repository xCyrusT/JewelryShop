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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHDBans = new HashSet<ChiTietHDBan>();
        }

        [StringLength(5)]
        public string SanPhamID { get; set; }

        [StringLength(50)]
        public string TenSanPham { get; set; }

        [StringLength(5)]
        public string DanhMucID { get; set; }

        public double? DonGia { get; set; }

        [StringLength(10)]
        public string DonViTinh { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(100)]
        public string Anh { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDBan> ChiTietHDBans { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
