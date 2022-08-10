using Seminar_Oblak.Models.Base;
using Seminar_Oblak.Models.Dbo.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Seminar_Oblak.Models.Dbo
{
    public class ProductCategory : ProductCategoryBase, IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ProductCategory")]
        public int ProductId { get; set; }
        public DateTime Created { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
