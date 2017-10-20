using Bookish.data_access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            var database = new Database();
            List<Books> ourBooks = database.GetBookInformation();
            ViewBag.books = ourBooks;
            return View();
        }
    }
}