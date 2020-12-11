using System.Collections.Generic;

namespace ShopVinhUniversity.Entities
{
    public class User
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Product> OwnedProducts { get; set; }
    }
}
