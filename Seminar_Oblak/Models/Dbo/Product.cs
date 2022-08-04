using Seminar_Oblak.Models.Base;
using Seminar_Oblak.Models.Dbo.Base;

namespace Seminar_Oblak.Models.Dbo
{
    public class Product : ProductBase, IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }

    
}
