using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JewelryShop.Model;
using JewelryShop.Repository;
using PagedList;

namespace JewelryShop.Areas.Administrator.Controllers
{
    public class SanPhamController : Controller
    {
        SanPhamRepository spRepo = null;
        DanhMucRepository dmRepo = null;

        public SanPhamController()
        {
            spRepo = new SanPhamRepository();
            dmRepo = new DanhMucRepository();
        }

        // GET: Administrator/SanPham
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPaging(int? page)
        {
            int pageSize = 10; // Số sản phẩm của 1 trang
            int pageNum = (page ?? 1); // If(page==null)->set page==1

            return PartialView("_GetPaging", spRepo.GetAll().ToPagedList(pageNum, pageSize));
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = spRepo.GetByID(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }
        
        public ActionResult Create()
        {
            ViewBag.DanhMucID = new SelectList(dmRepo.GetAll(), "DanhMucID", "TenDanhMuc");
            return View();
        }
        
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "SanPhamID,TenSanPham,DonGia,DonViTinh,Anh,MoTa,NgayCapNhat,DanhMucID,SoLuongBan,TrangThai")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                spRepo.Create(sanPham);
                return RedirectToAction("Index");
            }

            return View(sanPham);
        }
        
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = spRepo.GetByID(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SanPhamID,TenSanPham,DonGia,DonViTinh,Anh,MoTa,NgayCapNhat,DanhMucID,SoLuongBan,TrangThai")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                spRepo.Update(sanPham);
                return RedirectToAction("Index");
            }
            return View(sanPham);
        }
        
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = spRepo.GetByID(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            spRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
