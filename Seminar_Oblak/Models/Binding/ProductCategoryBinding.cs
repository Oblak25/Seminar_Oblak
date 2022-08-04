using Seminar_Oblak.Models.Base;

namespace Seminar_Oblak.Models.Binding
{
    public class ProductCategoryBinding : ProductCategoryBase
    {
    }

    public class ProductCategoryUpdateBinding : ProductCategoryBinding
    {
        public int Id { get; set; }
    }
}
