using exam.Models;
using exam.RepositoryInterface;

namespace exam.Repository
{
    public class ImageRepository : IImageRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ICloudinaryService _cloudinaryService;

        public ImageRepository(ApplicationDbContext dbContext, ICloudinaryService cloudinaryService)
        {
            _dbContext = dbContext;
            _cloudinaryService = cloudinaryService;
        }

        public async Task<Image> GetByIdAsync(int id)
        {
            return await _dbContext.Images.FindAsync(id);
        }

        public async Task AddAsync(Image image)
        {
            image.Url = _cloudinaryService.UploadImage(image.Url);
            _dbContext.Images.Add(image);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Image image)
        {
            _cloudinaryService.DeleteImage(image.PublicId);
            _dbContext.Images.Remove(image);
            await _dbContext.SaveChangesAsync();
        }

    }
}
