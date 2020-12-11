namespace ShopVinhUniversity.Entities
{
  public class OrderDetail
  {
    public string ID { get; set; }
    public long CreatedTime { get; set; }
    public long UpdatedTime { get; set; }
    public string ProductID { get; set; }
    public int Amount { get; set; }

    public virtual Product Product { get; set; }
  }
}
