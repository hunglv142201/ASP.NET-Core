namespace ShopVinhUniversity.Entities
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public User Owner { get; set; }
    }
}
