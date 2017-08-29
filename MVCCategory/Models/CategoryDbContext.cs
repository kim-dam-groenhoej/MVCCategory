namespace MVCCategory.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /// <summary>
    /// Denne DbContext kan erstattets med jeres DbContext
    /// </summary>
    public partial class CategoryDbContext : DbContext
    {
        public CategoryDbContext()
            : base("name=CategoryDbContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        // Flyt dette kode over i jeres DbContext
        public DbSet<Category> Categories { get; set; }
    }
}
