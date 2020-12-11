using System.Collections.Generic;

namespace ShopVinhUniversity.Entities
{
  public class User
  {
    public string ID { get; set; }
    public long CreatedTime { get; set; }
    public long UpdatedTime { get; set; }
    public string FullName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
  }
}
