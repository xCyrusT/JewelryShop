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
    public class HoaDonController : Controller
    {
        HoaDonRepository hdRepo = null;

        public HoaDonController()
        {
            hdRepo = new HoaDonRepository();
        }

        // GET: Administrator/HoaDon
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPaging(int? page)
        {
            int pageSize = 10; // Số sản phẩm của 1 trang
            int pageNum = (page ?? 1); // If(page==null)->set page==1

            return PartialView("_GetPaging", hdRepo.GetAll().ToPagedList(pageNum, pageSize));
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDon hoaDon = hdRepo.GetByID(id);
            if (hoaDon == null)
            {
                return HttpNotFound();
            }
            return View(hoaDon);
        }
        
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDon hoaDon = hdRepo.GetByID(id);
            if (hoaDon == null)
            {
                return HttpNotFound();
            }
            return View(hoaDon);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HoaDonID,KhachHangID,NgayDatHang,NgayGiaoHang,NguoiNhan,DiaChiNhan,DienThoai,TongTien,TrangThai")] HoaDon hoaDon)
        {
            if (ModelState.IsValid)
            {
                hdRepo.Update(hoaDon);
                return RedirectToAction("Index");
            }
            return View(hoaDon);
        }
    }
}