using Seminar_Oblak.Models.Base;
using Seminar_Oblak.Models.Dbo.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seminar_Oblak.Models.Dbo
{
    public class Product : ProductBase, IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        [ForeignKey("Product")]
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }

    
}
