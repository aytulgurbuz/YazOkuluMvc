using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBlog.Models;
using PagedList;

namespace MvcBlog.Controllers
{
    public class HomeController : Controller
    {
        mvcblogDB db = new mvcblogDB();
        // GET: Home
        public ActionResult Index(int Page = 1)
        {
            var makale = db.Makales.OrderByDescending(m => m.MakaleId).ToPagedList(Page, 5);
            return View(makale);
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult iletisim()
        {
            return View();
        }
        public ActionResult KategoriPartial()
        {
            return View(db.Kategoris.ToList());
        }
    }
}