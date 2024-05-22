using Microsoft.AspNetCore.Http;

namespace Data.Interfaces
{
    public interface IFileService
    {
        Task<string> SaveProductImage(IFormFile file);
        Task DeleteProductImage(string path);
    }
}