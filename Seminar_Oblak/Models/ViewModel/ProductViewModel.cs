using Seminar_Oblak.Models.Base;

namespace Seminar_Oblak.Models.ViewModel
{
    public class ProductViewModel : ProductBase
    {
        public int Id { get; set; }
        public ProductCategoryViewModel ProductCategory { get; set; }
    }
}
