using exam.Models;

namespace exam.RepositoryInterface
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategorys();
        Task<Category> GetCategoryById(int id);
        Task AddCategory(Category category);
        Task UpdateCategory(Category category);
        Task DeleteCategory(int id);
    }
}
