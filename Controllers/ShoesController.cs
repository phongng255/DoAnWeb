using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAW.Models;
using DAW.Models.ShoeEntities;

namespace DAW.Controllers
{
    public class ShoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Shoes
        public ActionResult Index()
        {
            var shoes = db.Shoes.Include(s => s.Brand).Include(s => s.Category);
            return View(shoes.ToList());
        }
        public ActionResult Xem(int id)
        {
            var shoes = db.Shoes.Include(s => s.Brand.Id == id).Include(s => s.Category);
            return View(shoes);
        }
        // GET: Shoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shoe shoe = db.Shoes.Find(id);
            if (shoe == null)
            {
                return HttpNotFound();
            }
            return View(shoe);
        }
        
        

        // GET: Shoes/Create

    }
}
