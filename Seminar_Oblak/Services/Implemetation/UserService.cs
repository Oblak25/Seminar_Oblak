using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Seminar_Oblak.Data;
using Seminar_Oblak.Models.Binding;
using Seminar_Oblak.Models.Dbo;
using Seminar_Oblak.Models.ViewModel;
using Seminar_Oblak.Services.Interface;

namespace Seminar_Oblak.Services.Implemetation
{
    public class UserSevice : IUserSevice
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IMapper mapper;
        private SignInManager<ApplicationUser> signInManager;
        private readonly ApplicationDbContext db;


        public UserSevice(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper,
            SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
            this.signInManager = signInManager;
            this.db = db;

        }

        public async Task<ApplicationUser?> CreateUserAsync(UserBinding model, string role)
        {
            var find = await userManager.FindByEmailAsync(model.Email);
            if (find != null)
            {
                return null;
            }
            var user = mapper.Map<ApplicationUser>(model);
            var adress = mapper.Map<Adress>(model.UserAdress);
            user.Adress = new List<Adress>() { adress };
            var createdUser = await userManager.CreateAsync(user, model.Password);
            if (createdUser.Succeeded)
            {
                var userAddedToRole = await userManager.AddToRoleAsync(user, role);
                if (!userAddedToRole.Succeeded)
                {
                    throw new Exception("User was not assigned a role");
                }
            }
            return user;
        }

        //public async Task<ProductViewModel> AddUserAsync(UserBinding model)
        //{
        //    var dbo = mapper.Map<Product>(model);
        //    var productCategory = await db.ProductCategory.FindAsync(model.ProductCategoryId);
        //    if (productCategory == null)
        //    {
        //        return null;
        //    }
        //    dbo.ProductCategory = productCategory;
        //    db.Product.Add(dbo);
        //    await db.SaveChangesAsync();
        //    return mapper.Map<ProductViewModel>(dbo);
        //}

        public async Task<List<ApplicationUserViewModel>> GetUsersAsync()
        {
            var dbo = await db.Users
                .Include(x => x.Adress)
                .ToListAsync();
            return dbo.Select(x => mapper.Map<ApplicationUserViewModel>(x)).ToList();

        }

        //public async Task<List<ApplicationUserViewModel>> GetUsersAsync()
        //{
        //    var dbo = db.ApplicationUser.ToList();
        //    return dbo.Select(x => mapper.Map<ApplicationUserViewModel>(x)).ToList();

        //}

        public async Task<ApplicationUser> CreateNewUserAsync(UserBinding model, string role)
        {
            var findUserByEmail = await userManager.FindByEmailAsync(model.Email);
            if (findUserByEmail != null)
            {
                throw new Exception("ASccount Already Exists");
            }
            var user = mapper.Map<ApplicationUser>(model);
            var createUser = await userManager.CreateAsync(user, model.Password);
            if (!createUser.Succeeded) return user;

            var assignRole = await userManager.AddToRoleAsync(user, role);
            if (!assignRole.Succeeded)
            {
                throw new Exception("Role Error ");
            }

            return user;
        }


    }
}
