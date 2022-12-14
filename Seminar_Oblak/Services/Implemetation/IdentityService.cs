using Microsoft.AspNetCore.Identity;
using Seminar_Oblak.Data;
using Seminar_Oblak.Models;
using Seminar_Oblak.Models.Dbo;
using Seminar_Oblak.Services.Interface;

namespace Seminar_Oblak.Services.Implemetation
{
    public class IdentityService : IIdentityService
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;

        public IdentityService(IServiceScopeFactory scopeFactory)
        {

            using (var scope = scopeFactory.CreateScope())
            {
                this.userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                this.roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();


                CreateRoleAsync(Roles.Admin).Wait();
                CreateRoleAsync(Roles.BasicUser).Wait();
                CreateRoleAsync(Roles.Employee).Wait();


                CreateUserAsync(new ApplicationUser
                {
                    Firstname = "Glavni",
                    Lastname = "Gazda",
                    Email = "admin@admin.com",
                    UserName = "admin@admin.com",
                    DOB = DateTime.Now.AddYears(-80),
                    PhoneNumber = "+385996666666",
                    
                  

                }, "Pa$$word321", Roles.Admin).Wait();

                CreateUserAsync(new ApplicationUser
                {
                    Firstname = "Pero",
                    Lastname = "Perokovic",
                    Email = "pero@pero.com",
                    UserName = "pero@pero.com",
                    DOB = DateTime.Now.AddYears(-20),
                    PhoneNumber = "+3859912685678",
                  

                }, "Pa$$word321", Roles.BasicUser).Wait();

                CreateUserAsync(new ApplicationUser
                {
                    Firstname = "Marko",
                    Lastname = "Markovic",
                    Email = "marko@marko.hr",
                    UserName = "marko@marko.hr",
                    DOB = DateTime.Now.AddYears(-35),
                    PhoneNumber = "+3859989345278",
                  

                }, "Pa$$w0rd", Roles.BasicUser).Wait();
            }


        }

        public async Task CreateRoleAsync(string role)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole
                {
                    Name = role

                });
            }

        }

        public async Task CreateUserAsync(ApplicationUser user, string password, string role)
        {         
            var find = await userManager.FindByEmailAsync(user.Email);
            if (find != null)
            {
                return;
            }
            user.EmailConfirmed = true;     
            var createdUser = await userManager.CreateAsync(user, password);          
            if (createdUser.Succeeded)
            {             
                var userAddedToRole = await userManager.AddToRoleAsync(user, role);
                if (!userAddedToRole.Succeeded)
                {
                    throw new Exception("Korisnik nije dodan u rolu!");
                }
            }



        }
    }
}
