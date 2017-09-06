using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCategory.Models
{
    public class Category
    {
        private CategoryDbContext context;

        public Category()
        {
            this.context = new CategoryDbContext();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Category ParentCategory { get; set; }

        public int? ParentCategoryId { get; set; }

        public IQueryable<Category> Children
        {
            get {
                return context.Categories.Where(c => c.ParentCategoryId == this.Id);
            }
        }

        public virtual ICollection<Product> Products { get; set; }
    }
}