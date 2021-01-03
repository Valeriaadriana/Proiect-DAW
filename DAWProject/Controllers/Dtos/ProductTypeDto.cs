namespace DAWProject.Controllers.Dtos
{
    public class ProductTypeDto : BaseDto
    {
        public string Name { get; set; }
        public bool Perishable { get; set; }
    }
}