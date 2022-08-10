using Microsoft.AspNetCore.Mvc;
using Seminar_Oblak.Models;
using Seminar_Oblak.Services.Interface;
using System.Diagnostics;

namespace Seminar_Oblak.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IActionResult> Products()
        {
            var products = await productService.GetProductsAsync();
            return View(products);
        }

        public IActionResult Index()
        {
            return View(productService.GetProductsAsync().Result);
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await productService.GetProductAsync(id);
            return View(product);
        }

        public IActionResult Categories()
        {
            return View(productService.GetProductCategorysAsync().Result);
        }

        [HttpGet]
        public async Task<IActionResult> CategoryDetails(int id)
        {
            var product = await productService.GetProductCategoryAsync(id);
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}