namespace NLayer.Core.DTOs
{
    public class CategoryWithProductsDto : CategoryDto
    {
        public ICollection<ProductDto>? Products { get; set; }
    }
}
