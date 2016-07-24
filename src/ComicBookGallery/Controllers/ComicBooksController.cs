using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
       
        public ActionResult Details()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                return Redirect("/");
            }

            return Content("Hello There");



        }

        // GET: ComicBooks
        public ActionResult Index()
        {
            return View();
        }
    }
}