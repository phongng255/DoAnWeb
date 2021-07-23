using DAW.Models;
using DAW.Models.ShoeEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAW.Controllers
{
    public class AdController : Controller
    {
        // GET: Ad
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }
        public ActionResult Themloaisanpham()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Themloaisanpham(Category th, HttpPostedFileBase fileupload)
        {
            if (fileupload == null)
            {
                ViewBag.Thongbao = "Vui lòng chọn ảnh bìa";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    string fileName = Path.GetFileName(fileupload.FileName);
                    string path = Path.Combine(Server.MapPath("./Content/Giay/"),fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Thongbao = "Hình ảnh đã trùng";
                    }
                    else
                    {
                        fileupload.SaveAs(path);
                    }
                    th.image = fileName;
                    db.Categories.Add(th);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}