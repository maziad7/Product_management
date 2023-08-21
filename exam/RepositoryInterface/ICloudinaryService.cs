using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Configuration;

namespace exam.RepositoryInterface
{
    public interface ICloudinaryService
    {
        string UploadImage(string imagePath);
        void DeleteImage(string publicId);
    }
}
