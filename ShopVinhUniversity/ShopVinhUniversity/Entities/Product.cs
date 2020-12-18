namespace ShopVinhUniversity.Entities
{
  public class Product
  {
    public string ID { get; set; }
    public long CreatedTime { get; set; }
    public long UpdatedTime { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string ThumbnailSrc { get; set; }
    public string CategoryID { get; set; }

    public virtual Category Category { get; set; }
  }
}
