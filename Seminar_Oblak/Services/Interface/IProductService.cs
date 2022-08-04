using Seminar_Oblak.Models.Binding;
using Seminar_Oblak.Models.Dbo;
using Seminar_Oblak.Models.ViewModel;

namespace Seminar_Oblak.Services.Interface
{
    public interface IProductService
    {
        Task<ProductViewModel> AddProductAsync(ProductBinding model);
        Task<ProductCategoryViewModel> AddProductCategoryAsync(ProductCategoryBinding model);
        Task<ProductViewModel> GetProductAsync(int id);
        Task<ProductCategoryViewModel> GetProductCategoryAsync(int id);
        Task<List<ProductCategoryViewModel>> GetProductCategorysAsync();
        Task<List<ProductViewModel>> GetProductsAsync();
        Task<ProductViewModel> UpdateProductAsync(ProductUpdateBinding model);
        Task<ProductCategoryViewModel> UpdateProductCategoryAsync(ProductCategoryUpdateBinding model);
        Task DeleteProductAsync(Product model);
        Task DeleteProductCategoryAsync(ProductCategory model);

    }
}