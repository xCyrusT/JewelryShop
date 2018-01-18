using JewelryShop.Model;
using JewelryShop.Repository;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JewelryShop.Controllers
{
    public class SanPhamController : Controller
    {
        SanPhamRepository spRepo = null;

        public SanPhamController()
        {
            spRepo = new SanPhamRepository();
        }

        // GET: SanPham
        public ActionResult Index(int id)
        {
            return View(spRepo.GetAll().Where(x => x.DanhMucID == id).ToList());
        }

        public ActionResult Details(int id)
        {
            return View(spRepo.GetByID(id));
        }

        public ActionResult Search(string keyword, int? page)
        {
            List<SanPham> listSach = new List<SanPham>();
            ViewBag.search = keyword;
            if (!String.IsNullOrEmpty(keyword))
            {
                listSach = spRepo.GetAll().Where(x => x.TenSanPham.ToLower().Contains(keyword.ToLower())).ToList();
            }
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(listSach.ToPagedList(pageNumber, pageSize));
        }
    }
}