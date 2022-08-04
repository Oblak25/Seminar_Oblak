namespace Seminar_Oblak.Models.Base
{
    public abstract class AdressBase
    {

        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public int HouseNumbering { get; set; }

        public int PostalCode { get; set; }
    }
}
