﻿namespace Seminar_Oblak.Models.Binding
{
    public class UserBinding
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public AdressBinding UserAdress { get; set; }
    }
}
