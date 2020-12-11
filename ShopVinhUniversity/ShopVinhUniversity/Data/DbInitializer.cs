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
      admin.FullName = "Le Viet Hung";
      admin.Username = "admin";
      admin.Password = "abc123";

      context.Users.Add(admin);

      Product[] products = new Product[]
      {
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 1", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 2", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 3", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 4", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 5", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 6", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 7", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 8", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 9", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 10", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 11", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 12", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 13", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 14", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID },
        new Product { ID = Guid.NewGuid().ToString(), Name = "Product 15", Price = 10000, ThumbnailSrc = "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg", OwnerID = admin.ID }
      };

      foreach (Product p in products)
      {
        context.Products.Add(p);
      }

      context.SaveChanges();
    }
  }
}
