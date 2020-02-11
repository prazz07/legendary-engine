﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "fruit Pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cheese Cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal Pies" });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "hegfuowgy",
                LongDescription = "ygyugfyugfyuft",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek=true,
                ImageThumbnailUrl="",
                AllergyInformation=""

            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "Blueberry Cheese Cakes",
                Price = 12.95M,
                ShortDescription = "hegfuowgy",
                LongDescription = "ygyugfyugfyuft",
                CategoryId = 2,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""

            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "choco Pie",
                Price = 12.95M,
                ShortDescription = "hegfuowgy",
                LongDescription = "ygyugfyugfyuft",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""

            }) ;
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "hegfuowgy",
                LongDescription = "ygyugfyugfyuft",
                CategoryId = 3,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""

            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 4,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "hegfuowgy",
                LongDescription = "ygyugfyugfyuft",
                CategoryId = 3,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""

            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 5,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "hegfuowgy",
                LongDescription = "ygyugfyugfyuft",
                CategoryId = 2,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""

            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 6,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "hegfuowgy",
                LongDescription = "ygyugfyugfyuft",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""

            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 7,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "hegfuowgy",
                LongDescription = "ygyugfyugfyuft",
                CategoryId = 2,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""

            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 8,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "hegfuowgy",
                LongDescription = "ygyugfyugfyuft",
                CategoryId = 3,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""

            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 9,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "hegfuowgy",
                LongDescription = "ygyugfyugfyuft",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""

            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 10,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "hegfuowgy",
                LongDescription = "ygyugfyugfyuft",
                CategoryId = 3,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""

            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 11,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "hegfuowgy",
                LongDescription = "ygyugfyugfyuft",
                CategoryId = 2,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""

            });
        }
    }
}
