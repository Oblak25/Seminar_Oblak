using Seminar_Oblak.Models.Dbo;

namespace Seminar_Oblak.Services.Interface
{
    public interface IIdentityService
    {
        Task CreateRoleAsync(string role);
        Task CreateUserAsync(ApplicationUser user, string password, string role);
    }
}