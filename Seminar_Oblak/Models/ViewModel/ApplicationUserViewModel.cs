using Seminar_Oblak.Models.Base;
using Seminar_Oblak.Models.Dbo;

namespace Seminar_Oblak.Models.ViewModel
{
    public class ApplicationUserViewModel : ApplicationUser
    {
        public string Id { get; set; }
        public List<AdressViewModel> Adress { get; set; }
        //public Roles Roles { get; set; }
    }
}
