namespace Entity
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}