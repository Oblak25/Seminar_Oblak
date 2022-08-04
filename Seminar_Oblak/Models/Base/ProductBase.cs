namespace Seminar_Oblak.Models.Base
{
    public abstract class ProductBase
    {
       
        public string Title { get; set; }
        
        public string Description { get; set; }

        public decimal Quantity { get; set; }

        
        public decimal Price { get; set; }
    }
}
