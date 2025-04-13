namespace WebApplication3.Services.Storage
{
    public interface IStorageService
    {
        string Save(IFormFile formFile);
        Stream? Get(string fileUrl);
        bool Delete(string fileUrl);
    }
}
