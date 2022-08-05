using Seminar_Oblak.Models.Base;
using Seminar_Oblak.Models.Dbo.Base;
using System.ComponentModel.DataAnnotations;

namespace Seminar_Oblak.Models.Dbo
{
    public class Adress : AdressBase, IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime Created { get; set; }
    }
}
