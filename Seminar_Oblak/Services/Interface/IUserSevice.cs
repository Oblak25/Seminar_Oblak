using Seminar_Oblak.Models.Binding;
using Seminar_Oblak.Models.Dbo;

namespace Seminar_Oblak.Services.Interface
{
    public interface IUserSevice
    {
        Task<ApplicationUser?> CreateUserAsync(UserBinding model, string role);
    }
}