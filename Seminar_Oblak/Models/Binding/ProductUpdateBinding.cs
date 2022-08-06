using Seminar_Oblak.Models.Base;
using Seminar_Oblak.Models.ViewModel;

namespace Seminar_Oblak.Models.Binding
{
    public class ProductUpdateBinding : ProductBase
    {
        public int Id { get; set; }
        public ProductCategoryViewModel ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }
        public IFormFile ProductImg { get; set; }

    }
}
