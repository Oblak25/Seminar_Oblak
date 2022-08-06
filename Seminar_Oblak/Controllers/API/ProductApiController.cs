using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seminar_Oblak.Data;
using Seminar_Oblak.Models.Dbo;
using Seminar_Oblak.Models.ViewModel;
using Seminar_Oblak.Services.Interface;

namespace Seminar_Oblak.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        private readonly IProductService productService;

        public ProductApiController(ApplicationDbContext db,IProductService productService)
        {
            this.db = db;
            this.productService = productService;
        }

        [HttpGet]
        [Route("Products")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProducts()
        {
            var dbo = await db.Product
                 .Include(x => x.ProductCategory)
                 .ToListAsync();
            return Ok(dbo.Select(x => x).ToList());
        }

        [HttpGet]
        [Route("product/{id}")]
        [ProducesResponseType(typeof(ProductViewModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProductAsync(int id)
        {
            return Ok(await productService.GetProductAsync(id));
        }
    }
}
