using System.Net.Mime;
using Seminar_Oblak.Models.Base;

namespace Seminar_Oblak.Models.ViewModel
{
    public class FileStorageViewModel : FileStorageBase
    {
        public int Id { get; set; }
    }


    public class FileStorageExpendedViewModel : FileStorageBase
    {
        public int Id { get; set; }
        public string Base64 { get; set; }
        public FileStream FileStream { get; set; }
        public ContentDisposition ContentDisposition { get; set; }
    }
}
