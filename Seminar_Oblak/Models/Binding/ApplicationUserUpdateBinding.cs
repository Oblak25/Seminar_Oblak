using Seminar_Oblak.Models.Binding;
using Seminar_Oblak.Models.Dbo;

namespace Seminar_Oblak.Models.Models.Binding
{
    public class ApplicationUserUpdateBinding : ApplicationUser
    {
        public string? Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime? DOB { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public string? Role { get; set; }



    }
}
