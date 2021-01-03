namespace DAWProject.Controllers.Dtos
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public ProductTypeDto ProductType { get; set; }
        public double Price { get; set; }
    }
}