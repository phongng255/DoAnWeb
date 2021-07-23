using DAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAW.Controllers
{
    public class TheLoaiController : Controller
    {
        // GET: TheLoai
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Loai(int id)
        {
            var list = db.Shoes.Where(p => p.CategoryId == id).ToList();
            return View(list);
        }
    }
}