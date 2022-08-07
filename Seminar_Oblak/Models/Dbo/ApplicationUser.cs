using Microsoft.AspNetCore.Identity;

namespace Seminar_Oblak.Models.Dbo
{
    public class ApplicationUser : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }      
        public DateTime? DOB { get; set; }
      

        //public Roles Roles { get; set; }
    }
}
