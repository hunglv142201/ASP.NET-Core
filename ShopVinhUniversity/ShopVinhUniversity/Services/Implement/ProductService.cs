using ShopVinhUniversity.Data;
using ShopVinhUniversity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopVinhUniversity.Services.Implement
{
  public class ProductService : IProductService
  {
    private readonly ApplicationDbContext _context;

    public ProductService(ApplicationDbContext context)
    {
      _context = context;
    }

    public ICollection<Product> GetAll(int page = 0, int size = 10)
    {
      return _context.Products.OrderByDescending(e => e.CreatedTime).Skip(page * size).Take(size).ToArray();
    }

    public Product GetById(string id)
    {
      return _context.Products.FirstOrDefault(e => e.ID == id);
    }

    public Product Create(Product product)
    {
      Product newProduct = new Product
      {
        ID = Guid.NewGuid().ToString(),
        CreatedTime = DateTime.Now.Ticks,
        UpdatedTime = DateTime.Now.Ticks,
        Name = product.Name,
        Price = product.Price,
        ThumbnailSrc = product.ThumbnailSrc,
        CategoryID = product.CategoryID
      };

      _context.Products.Add(newProduct);
      _context.SaveChanges();

      return newProduct;
    }

    public Product Update(Product product)
    {
      Product productToUpdate = GetById(product.ID);
      if (productToUpdate == null)
      {
        throw new Exception("Product not found");
      }

      productToUpdate.UpdatedTime = DateTime.Now.Ticks;
      productToUpdate.Name = product.Name;
      productToUpdate.Price = product.Price;
      productToUpdate.ThumbnailSrc = product.ThumbnailSrc;
      productToUpdate.CategoryID = product.CategoryID;

      _context.SaveChanges();

      return productToUpdate;
    }

    public void Delete(string id)
    {
      _context.Products.Remove(GetById(id));
      _context.SaveChanges();
    }
  }
}
