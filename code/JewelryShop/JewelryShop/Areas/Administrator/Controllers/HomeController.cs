using JewelryShop.Model;
using JewelryShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JewelryShop.Areas.Administrator.Controllers
{
    public class HomeController : Controller
    {
        NhanVienRepository nvRepo = null;

        public HomeController()
        {
            nvRepo = new NhanVienRepository();
        }

        // GET: Administrator/Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string pass)
        {
            NhanVien nv = nvRepo.GetAll().SingleOrDefault(x => x.Email == email && x.Pass == pass && x.TrangThai == 1);
            if(nv != null)
            {
                Session["NhanVienID"] = nv.NhanVienID;
                Session["TenNV"] = nv.TenNhanVien;
                Session["Email"] = nv.Email;
                Session["Avatar"] = nv.Avatar;
                return RedirectToAction("Index", "SanPham");
            }
            ViewBag.error = "Sai tên đăng nhập hoặc mật khẩu!";
            return View();
        }

        public ActionResult Logout()
        {
            Session["NhanVienID"] = null;
            Session["TenNhanVien"] = null;
            Session["Email"] = null;
            Session["Avatar"] = null;

            return View("Login", "Home");
        }
    }
}