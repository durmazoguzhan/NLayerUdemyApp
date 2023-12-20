using NLayer.Core.DTOs;
using NLayer.Core.Entities;

namespace NLayer.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<CustomResponseDto<CategoryWithProductsDto>> GetCategoryByIdWithProductsAsync(int id);
    }
}
