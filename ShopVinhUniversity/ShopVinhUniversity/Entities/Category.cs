using System.Collections.Generic;

namespace ShopVinhUniversity.Entities
{
  public class Category
  {
    public string ID { get; set; }
    public long CreatedTime { get; set; }
    public long UpdatedTime { get; set; }
    public string Title { get; set; }

    public virtual ICollection<Product> Products { get; set; }
  }
}
