﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Seminar_Oblak.Models.Dbo;
using Seminar_Oblak.Models.ViewModel;
using Seminar_Oblak.Models.Binding;

namespace Seminar_Oblak.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<FileStorage> FileStorage { get; set; }
        public DbSet<Seminar_Oblak.Models.ViewModel.ProductViewModel>? ProductViewModel { get; set; }
        public DbSet<Seminar_Oblak.Models.ViewModel.ProductCategoryViewModel>? ProductCategoryViewModel { get; set; }

        //public DbSet<Seminar_Oblak.Models.ViewModel.ProductViewModel>? ProductViewModel { get; set; }
        //public DbSet<Seminar_Oblak.Models.ViewModel.ProductCategoryViewModel>? ProductCategoryViewModel { get; set; }
        //public DbSet<Seminar_Oblak.Models.Binding.ProductCategoryUpdateBinding>? ProductCategoryUpdateBinding { get; set; }
    }
}