using System;
using System.Linq;
using ShopVinhUniversity.Entities;

namespace ShopVinhUniversity.Data
{
  public static class DbInitializer
  {
    public static void Initialize(ApplicationDbContext context)
    {
      //if (context.Users.Any())
      //{
      //    return;
      //}

      // Truncate
      context.Users.RemoveRange(context.Users.ToArray());
      context.Products.RemoveRange(context.Products.ToArray());
      context.SaveChanges();

      User admin = new User();
      admin.ID = Guid.NewGuid().ToString();
      admin.CreatedTime = DateTime.Now.Ticks;
      admin.UpdatedTime = DateTime.Now.Ticks;
      admin.FullName = "Le Viet Hung";
      admin.Username = "admin";
      admin.Password = "abc123";

      context.Users.Add(admin);

      Product[] products = new Product[]
      {
        new Product
        {
          ID = Guid.NewGuid().ToString(),
          CreatedTime = DateTime.Now.Ticks,
          UpdatedTime = DateTime.Now.Ticks,
          Name = "Thú nhồi bông Doremon",
          Price = 138000,
          ThumbnailSrc = "https://salt.tikicdn.com/cache/w444/ts/product/fa/77/c3/ea0e006397a775fcb36e530fd78e04cd.jpg"
        },
        new Product
        {
          ID = Guid.NewGuid().ToString(),
          CreatedTime = DateTime.Now.Ticks,
          UpdatedTime = DateTime.Now.Ticks,
          Name = "Móc khóa đa năng",
          Price = 38000,
          ThumbnailSrc = "https://salt.tikicdn.com/cache/w444/ts/product/ed/58/1a/2bfb01012cf72c0de4cb2b35789e69cb.jpg"
        },
        new Product
        {
          ID = Guid.NewGuid().ToString(),
          CreatedTime = DateTime.Now.Ticks,
          UpdatedTime = DateTime.Now.Ticks,
          Name = "Sticker Among Us set",
          Price = 48000,
          ThumbnailSrc = "https://salt.tikicdn.com/cache/w444/ts/product/21/ff/e4/3746c16627e0f72d76b5f3e30c91eb95.jpg"
        },
        new Product
        {
          ID = Guid.NewGuid().ToString(),
          CreatedTime = DateTime.Now.Ticks,
          UpdatedTime = DateTime.Now.Ticks,
          Name = "Sticker Among Us set",
          Price = 48000,
          ThumbnailSrc = "https://salt.tikicdn.com/cache/w444/ts/product/21/ff/e4/3746c16627e0f72d76b5f3e30c91eb95.jpg"
        },
      };

      foreach (Product p in products)
      {
        context.Products.Add(p);
      }

      context.SaveChanges();
    }
  }
}
