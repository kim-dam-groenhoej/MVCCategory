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
            m.NewsletterVM = new NewsletterVM();
            m.LoginViewModel = new LoginViewModel()
            {
                TItle = "test"
            };
            m.RootCategories = context.Categories.Where(c => !c.ParentCategoryId.HasValue).ToList();

            return View(m);
        }

        public virtual ActionResult Category()
        {
            var vm = new CategoryVM();
            var context = new CategoryDbContext();

            var categoryModels = context.Categories.ToList();
            vm.Categories = categoryModels;

            return View(vm);
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

        public virtual ActionResult TestTrykMig(string test)
        {
            ViewBag.MessageCiick = "Klikkede her og udfyldte følgende: " + test;


            return View("Contact");
        }
    }
}