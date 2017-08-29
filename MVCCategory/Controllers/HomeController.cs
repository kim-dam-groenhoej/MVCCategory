using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCategory.ViewModels;
using MVCCategory.Models;

namespace MVCCategory.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            var context = new CategoryDbContext();
            var m = new IndexVM();
            m.RootCategories = context.Categories.Where(c => !c.ParentCategoryId.HasValue).ToList();

            return View(m);
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}