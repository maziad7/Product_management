using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using exam.RepositoryInterface;
using exam.Models;

namespace exam.Repository
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary _cloudinary;

        public CloudinaryService(IConfiguration configuration)
        {
            var cloudinaryConfig = configuration.GetSection("Cloudinary");
            var account = new Account(
                cloudinaryConfig["CloudName"],
                cloudinaryConfig["ApiKey"],
                cloudinaryConfig["ApiSecret"]
            );
            _cloudinary = new Cloudinary(account);
        }

        public string UploadImage(string imagePath)
        {
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(imagePath)
            };

            var uploadResult = _cloudinary.Upload(uploadParams);

            return uploadResult.SecureUri.AbsoluteUri;
        }

        public void DeleteImage(string publicId)
        {
            var deleteParams = new DeletionParams(publicId);

            _cloudinary.Destroy(deleteParams);
        }
    }
}
