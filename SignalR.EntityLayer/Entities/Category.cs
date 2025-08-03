namespace SignalR.EntityLayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool status { get; set; }
        public List<Product> Products { get; set; }
    }
}
