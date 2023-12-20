using Microsoft.EntityFrameworkCore;
using NLayer.Core.Entities;
using NLayer.Core.Repositories;

namespace NLayer.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetCategoryByIdWithProductsAsync(int id)
        {
            return await _context.Categories.Include(c => c.Products).Where(c => c.Id == id).FirstOrDefaultAsync();
        }
    }
}
