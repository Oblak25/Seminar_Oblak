using Seminar_Oblak.Models.Base;

namespace Seminar_Oblak.Models.ViewModel
{
    public class ApplicationUserViewModel : ApplicationUserBase
    {
        public string Id { get; set; }
        public List<AdressViewModel> Adress { get; set; }
    }
}
