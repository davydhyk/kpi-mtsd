namespace Models
{
    public class ProductModel : BaseModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
        public ProductTypeModel ProductTypeModel { get; set; }
    }
}