using exam.Models;
using exam.RepositoryInterface;
using Microsoft.EntityFrameworkCore;

namespace exam.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public async Task AddCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCategory(int id)
        {
            var category = await _dbContext.Categories.FindAsync(id);
            if (category != null)
            {
                _dbContext.Categories.Remove(category);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<Category> GetCategoryById(int id) => await _dbContext.Categories.FindAsync(id);
        

        public async Task<IEnumerable<Category>> GetCategorys()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task UpdateCategory(Category category)
        {
            _dbContext.Categories.Update(category);
            await _dbContext.SaveChangesAsync();
        }
    }
}
