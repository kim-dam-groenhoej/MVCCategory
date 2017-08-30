using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCategory.Models;
using MVCCategory.ViewModels;

namespace MVCCategory.Controllers
{
    public partial class CategoryController : Controller
    {
        // GET: Category
        public virtual ActionResult Index()
        {
            var m = new CategoryVM();
            var context = new CategoryDbContext();

            m.RootCategories = context.Categories.Where(c => c.ParentCategoryId == null).ToList();

            return View(m);
        }

        //[HttpPost]
        [HttpGet]
        public virtual ActionResult GetCategories(int id)
        {
            var context = new CategoryDbContext();
            var categories = context.Categories.Where(c => c.ParentCategoryId == id).ToList();

            return Json(categories.Select(c => new
            {
                c.Id,
                c.Name
            }), JsonRequestBehavior.AllowGet);
        }
    }
}