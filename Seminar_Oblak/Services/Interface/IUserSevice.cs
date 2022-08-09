using Seminar_Oblak.Models.Binding;
using Seminar_Oblak.Models.Dbo;
using Seminar_Oblak.Models.Models.Binding;
using Seminar_Oblak.Models.ViewModel;

namespace Seminar_Oblak.Services.Interface
{
    public interface IUserSevice
    {
        Task<ApplicationUser?> CreateUserAsync(UserAdminBinding model);
        Task<List<ApplicationUserViewModel>> GetUsersAsync();
        Task<ApplicationUser> CreateNewUserAsync(UserAdminBinding model);
        Task<ApplicationUserViewModel> GetUserAsync(string id);
        Task<ApplicationUserViewModel> UpdateUserAsync(UserAdminUpdateBinding model);
        Task DeleteUserAsync(ApplicationUser model);
        Task<List<UserRolesViewModel>> GetUserRoles();
        Task<string> GetUserRole(string id);
        Task<ApplicationUser?> CreateUserAsync(UserBinding model, string role);




    }
}