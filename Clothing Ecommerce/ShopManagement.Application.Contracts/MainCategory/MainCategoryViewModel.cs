namespace ShopManagement.Application.Contracts.MainCategory
{
    public class MainCategoryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string CreationDate { get; set; }
        public int CategoryCount { get; set; }
        public bool IsRemoved { get; set; }
    }
}