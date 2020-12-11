namespace ShopVinhUniversity.Entities
{
  public class Product
  {
    public string ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string ThumbnailSrc { get; set; }
    public string OwnerID { get; set; }

    public virtual User Owner { get; set; }
  }
}
