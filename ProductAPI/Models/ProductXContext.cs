using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class ProductXContext : DbContext
    {
        public ProductXContext(DbContextOptions<ProductXContext> options)
            : base(options)
        { }

        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<AttributeValue> AttributeValues { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comparision> Comparisions { get; set; }
        //public DbSet<ComparisionDetails> ComparisionDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Site> Sites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasOne(c => c.ParentCategory)
                .WithMany(pc => pc.SubCategories)
                .HasForeignKey(c => c.ParentCategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Comparision>()
                .HasOne(c => c.FirstProduct)
                .WithMany(pc => pc.Comparisions)
                .HasForeignKey(c => c.FirstProductId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Comparision>()
                .HasOne(c => c.SecondProduct)
                .WithMany(pc => pc.Comparisions)
                .HasForeignKey(c => c.SecondProductId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
