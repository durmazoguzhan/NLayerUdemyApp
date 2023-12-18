namespace NLayer.Core.DTOs
{
    public abstract class BaseUpdateDto
    {
        public int Id { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
