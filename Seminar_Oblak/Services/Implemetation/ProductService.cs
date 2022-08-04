﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Seminar_Oblak.Data;
using Seminar_Oblak.Models.Binding;
using Seminar_Oblak.Models.Dbo;
using Seminar_Oblak.Models.ViewModel;
using Seminar_Oblak.Services.Interface;

namespace Seminar_Oblak.Services.Implemetation
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;


        public ProductService(ApplicationDbContext db, IMapper mapper)
        {

            this.db = db;
            this.mapper = mapper;
        }

        public async Task<ProductViewModel> AddProductAsync(ProductBinding model)
        {
            var dbo = mapper.Map<Product>(model);
            var productCategory = await db.ProductCategory.FindAsync(model.ProductCategoryId);
            if (productCategory == null)
            {
                return null;
            }
            dbo.ProductCategory = productCategory;
            db.Product.Add(dbo);
            await db.SaveChangesAsync();
            return mapper.Map<ProductViewModel>(dbo);
        }

        public async Task<ProductViewModel> GetProductAsync(int id)
        {
            var dbo = await db.Product
                .Include(x => x.ProductCategory)
                .FirstOrDefaultAsync(x => x.Id == id);
            return mapper.Map<ProductViewModel>(dbo);

        }

        public async Task<List<ProductViewModel>> GetProductsAsync()
        {
            var dbo = await db.Product
                .Include(x => x.ProductCategory)
                .ToListAsync();
            return dbo.Select(x => mapper.Map<ProductViewModel>(x)).ToList();

        }

        public async Task<ProductCategoryViewModel> AddProductCategoryAsync(ProductCategoryBinding model)
        {
            var dbo = mapper.Map<ProductCategory>(model);
            db.ProductCategory.Add(dbo);
            await db.SaveChangesAsync();
            return mapper.Map<ProductCategoryViewModel>(dbo);
        }

        public async Task<ProductCategoryViewModel> GetProductCategoryAsync(int id)
        {
            var dbo = await db.ProductCategory.FindAsync(id);
            return mapper.Map<ProductCategoryViewModel>(dbo);

        }

        public async Task<List<ProductCategoryViewModel>> GetProductCategorysAsync()
        {
            var dbo = await db.ProductCategory.ToListAsync();
            return dbo.Select(x => mapper.Map<ProductCategoryViewModel>(x)).ToList();

        }

        public async Task<ProductViewModel> UpdateProductAsync(ProductUpdateBinding model)
        {
            var category = await db.ProductCategory.FirstOrDefaultAsync(x => x.Id == model.ProductCategoryId);
            var dbo = await db.Product.FindAsync(model.Id);
            mapper.Map(model, dbo);
            dbo.ProductCategory = category;
            await db.SaveChangesAsync();
            return mapper.Map<ProductViewModel>(dbo);
        }

        public async Task<ProductCategoryViewModel> UpdateProductCategoryAsync(ProductCategoryUpdateBinding model)
        {
            var dbo = await db.ProductCategory.FindAsync(model.Id);
            mapper.Map(model, dbo);
            await db.SaveChangesAsync();
            return mapper.Map<ProductCategoryViewModel>(dbo);
        }


        public async Task DeleteProductAsync(Product model)
        {
            var product = await db.Product.FirstOrDefaultAsync(X => X.Id == model.Id);
            db.Product.Remove(product);
            await db.SaveChangesAsync();
               
        }
    }
}