﻿using Seminar_Oblak.Models.Binding;
using Seminar_Oblak.Models.Dbo;
using Seminar_Oblak.Models.ViewModel;

namespace Seminar_Oblak.Services.Interface
{
    public interface IUserSevice
    {
        Task<ApplicationUser?> CreateUserAsync(UserBinding model, string role);
        Task<List<ApplicationUserViewModel>> GetUsersAsync();
        Task<ApplicationUser> CreateNewUserAsync(UserBinding model, string role);
    }
}