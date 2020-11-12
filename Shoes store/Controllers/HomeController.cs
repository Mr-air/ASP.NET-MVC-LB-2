using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using Shoes_store.Models;

namespace Shoes_store.Controllers
{
    public class HomeController : Controller
    {
        ShoesContext db = new ShoesContext();
        public ActionResult Index()
        {
            return View(db.Shoes);
        }


        public ActionResult GetFirma()
        {
            string[] firma = new string[] { "NiKE", "Forward" };
            return PartialView(firma);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.ShoesId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }
    
        public string CountNumberShoesInFirma(string firma)
        {
            var count = db.Shoes.Count(f => f.Firma == firma);
            return $"<h3>Количество обуви выбранной фирмы: {count}<h3>";
        }

        public FileResult GetFile()
        {
            // Путь к файлу
            string file_path = Server.MapPath("~/Files/ShoesPrice.xlsx");
            // Тип файла - content-type string
            string file_type = "application/xlsx";
            // Имя файла - необязательно
            string file_name = "ShoesPrice.xlsx";
            return File(file_path, file_type, file_name);
        }
    }
}