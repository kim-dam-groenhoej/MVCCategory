using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCCategory.Models;

namespace MVCCategory.ViewModels
{
    public class CategoryVM
    {
        public Category Category { get; set; }

        public List<Category> Categories { get; set; }

        public List<Category> RootCategories { get; set; }
    }
}