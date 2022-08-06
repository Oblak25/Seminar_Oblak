using Seminar_Oblak.Models.Dbo.Base;
using Seminar_Oblak.Models.Base;

namespace Seminar_Oblak.Models.Dbo
{
    public class FileStorage : FileStorageBase, IEntityBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }
}
