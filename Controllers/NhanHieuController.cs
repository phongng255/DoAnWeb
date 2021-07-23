using DAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAW.Controllers
{
    public class NhanHieuController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: NhanHieu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Xem(int id)
        {
            var list = db.Shoes.Where(p => p.BrandId == id).ToList();
            return View(list);
        }
    }
}