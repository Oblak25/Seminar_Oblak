using Seminar_Oblak.Models.Binding;
using Seminar_Oblak.Models.Dbo;

namespace Seminar_Oblak.Models.Models.Binding
{
    public class ApplicationUserUpdateBinding : ApplicationUser
    {
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public AdressBinding? UserAdress { get; set; }


    }
}
