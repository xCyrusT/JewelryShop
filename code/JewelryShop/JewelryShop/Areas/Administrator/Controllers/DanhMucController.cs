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
    public class DanhMucController : Controller
    {
        DanhMucRepository dmRepo = null;

        public DanhMucController()
        {
            dmRepo = new DanhMucRepository();
        }

        // GET: Administrator/DanhMuc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPaging(int? page)
        {
            int pageSize = 10; // Số sản phẩm của 1 trang
            int pageNum = (page ?? 1); // If(page==null)->set page==1

            return PartialView("_GetPaging", dmRepo.GetAll().ToPagedList(pageNum, pageSize));
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DanhMucID,TenDanhMuc,TrangThai")] DanhMuc danhMuc)
        {
            if (ModelState.IsValid)
            {
                dmRepo.Create(danhMuc);
                return RedirectToAction("Index");
            }

            return View(danhMuc);
        }
        
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMuc danhMuc = dmRepo.GetByID(id);
            if (danhMuc == null)
            {
                return HttpNotFound();
            }
            return View(danhMuc);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DanhMucID,TenDanhMuc,TrangThai")] DanhMuc danhMuc)
        {
            if (ModelState.IsValid)
            {
                dmRepo.Update(danhMuc);
                return RedirectToAction("Index");
            }
            return View(danhMuc);
        }
        
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMuc danhMuc = dmRepo.GetByID(id);
            if (danhMuc == null)
            {
                return HttpNotFound();
            }
            return View(danhMuc);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dmRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
