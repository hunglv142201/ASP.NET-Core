namespace ShopVinhUniversity.Entities
{
  public enum Status { PENDING, DELIVERING, DELIVERED, CANCELED };

  public class OrderDetail
  {
    public string ID { get; set; }
    public long CreatedTime { get; set; }
    public long UpdatedTime { get; set; }
    public int Amount { get; set; }
    public string ProductID { get; set; }
    public Status Status { get; set; } = Status.PENDING;
    public string Purchaser { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    public virtual Product Product { get; set; }
  }
}
