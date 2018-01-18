using JewelryShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JewelryShop.Controllers
{
    public class HomeController : Controller
    {
        SanPhamRepository spRepo = null;
        DanhMucRepository dmRepo = new DanhMucRepository();

        public HomeController()
        {
            spRepo = new SanPhamRepository();
        }
        public ActionResult _PartialViewDanhMuc()
        {
            return PartialView(dmRepo.GetAll());
        }

        public ActionResult Index()
        {
            ViewBag.listSPMoi = spRepo.GetAll().OrderByDescending(x => x.NgayCapNhat).Take(8).ToList();
            ViewBag.listSPBanChay = spRepo.GetAll().OrderByDescending(x => x.SoLuongBan).Take(8).ToList();

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}