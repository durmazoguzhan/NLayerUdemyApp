using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class CategoriesController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _service;

        public CategoriesController(IMapper mapper, ICategoryService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetCategoryByIdWithProducts(int id)
        {
            return CreateActionResult(await _service.GetCategoryByIdWithProductsAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _service.GetAllAsync();
            var categoriesDto = _mapper.Map<List<CategoryDto>>(categories);
            return CreateActionResult(CustomResponseDto<List<CategoryDto>>.Success(200, categoriesDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _service.GetByIdAsync(id);
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return CreateActionResult(CustomResponseDto<CategoryDto>.Success(200, categoryDto));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CategoryCreateDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            category.CreatedDate = DateTime.Now;
            category = await _service.AddAsync(category);
            return CreateActionResult(CustomResponseDto<CategoryDto>.Success(201, _mapper.Map<CategoryDto>(category)));
        }

        [HttpPut]
        public async Task<IActionResult> Put(CategoryUpdateDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            category.UpdatedDate = DateTime.Now;
            await _service.UpdateAsync(category);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(category);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
