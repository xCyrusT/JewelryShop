namespace JewelryShop.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class JewelryShopDbContext : DbContext
    {
        public JewelryShopDbContext()
            : base("name=JewelryShopDbContext")
        {
        }

        public virtual DbSet<ChiTietHDBan> ChiTietHDBans { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<HoaDonBan> HoaDonBans { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDonBan>()
                .HasOptional(e => e.ChiTietHDBan)
                .WithRequired(e => e.HoaDonBan);
        }
    }
}
