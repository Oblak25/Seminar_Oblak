using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Seminar_Oblak.Models;
using Seminar_Oblak.Models.Binding;
using Seminar_Oblak.Models.Dbo;
using Seminar_Oblak.Models.Models.Binding;
using Seminar_Oblak.Models.ViewModel;
using Seminar_Oblak.Services.Interface;

namespace Seminar_Oblak.Controllers
{
    [Authorize(Roles = Roles.Admin)]
    public class AdminController : Controller
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;
        private readonly IUserSevice userService;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AdminController(IProductService productService, IMapper mapper, IUserSevice userService, SignInManager<ApplicationUser> signInManager)
        {
            this.productService = productService;
            this.mapper = mapper;
            this.userService = userService;
            this.signInManager = signInManager;
        }

        public IActionResult AdministratorControl()
        {
            return View("AdministratorControl");
        }

        public IActionResult UserControl()
        {
            return View("UserAdministration");
        }


        public IActionResult ProductCategorysAdministration()
        {
            return View("ProductCategoryAdministration");
        }


        public async Task<IActionResult> GetAllProducts()
        {
            var products = await productService.GetProductsAsync();
            return View(products);
        }

        public async Task<IActionResult> GetAllProductCategorys()
        {
            var category = await productService.GetProductCategorysAsync();
            return View(category);
        }


        [HttpGet]
        public async Task<IActionResult> ProductAdministration()
        {
            var products = await productService.GetProductsAsync();
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> ProductCategoryAdministration()
        {
            var products = await productService.GetProductCategorysAsync();
            return View(products);
        }


        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var product = await productService.GetProductAsync(id);
            var model = mapper.Map<ProductUpdateBinding>(product);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductUpdateBinding model)
        {
            var product = await productService.UpdateProductAsync(model);
            return RedirectToAction("ProductAdministration");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var category = await productService.GetProductCategoryAsync(id);
            var model = mapper.Map<ProductCategoryUpdateBinding>(category);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(ProductCategoryUpdateBinding model)
        {
            var category = await productService.UpdateProductCategoryAsync(model);
            return RedirectToAction("ProductCategoryAdministration");
        }

        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductBinding model)
        {
            await productService.AddProductAsync(model);
            return RedirectToAction("ProductAdministration");
        }

        [HttpGet]
        public async Task<IActionResult> AddProductCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProductCategory(ProductCategoryBinding model)
        {
            await productService.AddProductCategoryAsync(model);
            return RedirectToAction("ProductCategoryAdministration");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await productService.GetProductAsync(id);
            var model = mapper.Map<Product>(product);
            return View(model);
        }

        [HttpPost, ActionName("DeleteProduct")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await productService.GetProductAsync(id);
            var model = mapper.Map<Product>(product);
            await productService.DeleteProductAsync(model);
            return RedirectToAction("ProductAdministration");
        }

        public async Task<IActionResult> DeleteProductCategory(int id)
        {
            var category = await productService.GetProductCategoryAsync(id);
            var model = mapper.Map<ProductCategory>(category);
            return View(model);
        }

        [HttpPost, ActionName("DeleteProductCategory")]
        public async Task<IActionResult> DeleteConfirmedCategory(int id)
        {
            var category = await productService.GetProductCategoryAsync(id);
            var model = mapper.Map<ProductCategory>(category);
            await productService.DeleteProductCategoryAsync(model);
            return RedirectToAction("ProductCategoryAdministration");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var product = await productService.GetProductAsync(id);
            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> CategoryDetails(int id)
        {
            var product = await productService.GetProductCategoryAsync(id);
            return View(product);
        }

        public async Task<IActionResult> UserAdministration()
        {
            var users = await userService.GetUsersAsync();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> AddUser()
        {
            return View();
        }      
      
        [HttpPost]
        public async Task<IActionResult> AddUser(UserAdminBinding model)
        {
            await userService.CreateNewUserAsync(model);
            return RedirectToAction("UserAdministration");
        }

        public async Task<IActionResult> UserDetails(string id)
        {
            var user = await userService.GetUserAsync(id);
            return View(user);
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userService.GetUserAsync(id);
            var model = mapper.Map<ApplicationUser>(user);
            return View(model);
        }

        [HttpPost, ActionName("DeleteUser")]
        public async Task<IActionResult> DeleteUserConfirmed(string id)
        {
            var user = await userService.GetUserAsync(id);
            var model = mapper.Map<ApplicationUser>(user);

            await userService.DeleteUserAsync(model);

            return RedirectToAction("UserAdministration");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateUser(string id)
        {
            var user = await userService.GetUserAsync(id);
            var model = mapper.Map<ApplicationUserUpdateBinding>(user);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserAdminUpdateBinding model)
        {
            await userService.UpdateUserAsync(model);
            return RedirectToAction("UserAdministration");
        }


    }
}
