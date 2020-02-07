namespace StockManagementSystem.ViewModel
{
    public class ProductViewModel
    {
        public int Id { set; get; }
        public string Code { get; set; } 
        public string Name { get; set; }
        public string Category { get; set; }
        public int ReorderLevel { get; set; }
        public string Description { get; set; }
    }
}
