using exam.Models;
namespace exam.RepositoryInterface
{
    public interface IImageRepository
    {
        Task<Image> GetByIdAsync(int id);
        Task AddAsync(Image image);
        Task DeleteAsync(Image image);
    }
}
