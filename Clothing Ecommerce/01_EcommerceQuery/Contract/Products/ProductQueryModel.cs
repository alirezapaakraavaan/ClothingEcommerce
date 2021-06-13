namespace _01_EcommerceQuery.Contract.Products
{
    public class ProductQueryModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Slug { get; set; }
        public bool IsRemoved { get; set; }
        public bool IsInStock { get; set; }
    }
}