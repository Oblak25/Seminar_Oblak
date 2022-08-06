using Seminar_Oblak.Models.ViewModel;

namespace Seminar_Oblak.Services.Interface
{
    public interface IFileStorageService
    {
        Task<FileStorageViewModel> AddFileToStorage(IFormFile file);
        Task<bool> DeleteFile(int id);
        bool DeletePhysicalFile(string filePath);
        Task<FileStorageExpendedViewModel> GetFile(long id);
    }
}