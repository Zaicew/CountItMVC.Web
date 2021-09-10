using System;
using System.Collections.Generic;
using System.Text;
using CountItMVC.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CountItMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<ApplicationUser> Users { get;set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemInMeal> ItemInMeals { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<CategoryTag> CategoryTag { get; set; }
        public DbSet<DayTag> DayTag { get; set; }
        public DbSet<ItemTag> ItemTag { get; set; }


        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        
            //many vs many relations (all tags)
            //itemtag
            builder.Entity<ItemTag>()
                .HasKey(it => new {it.ItemId, it.TagId});

            builder.Entity<ItemTag>()
                .HasOne<Item>(it => it.Item)
                .WithMany(i => i.ItemsTags)
                .HasForeignKey(it => it.ItemId);

            builder.Entity<ItemTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(i => i.ItemTags)
                .HasForeignKey(it => it.TagId);

            //daytag
            builder.Entity<DayTag>()
                .HasKey(it => new {it.DayId, it.TagId});

            builder.Entity<DayTag>()
                .HasOne<Day>(it => it.Day)
                .WithMany(i => i.DaysTags)
                .HasForeignKey(it => it.DayId);

            builder.Entity<DayTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(i => i.DayTags)
                .HasForeignKey(it => it.TagId);

            //categorytag
            builder.Entity<CategoryTag>()
                .HasKey(it => new {it.CategoryId, it.TagId});

            builder.Entity<CategoryTag>()
                .HasOne<Category>(it => it.Category)
                .WithMany(i => i.CategoriesTags)
                .HasForeignKey(it => it.CategoryId);

            builder.Entity<CategoryTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(i => i.CategoryTags)
                .HasForeignKey(it => it.TagId);
        }
    }
}
