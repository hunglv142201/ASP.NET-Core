using ShopVinhUniversity.Data;
using ShopVinhUniversity.Entities;
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
      return _context.Products.Skip(page * size).Take(size).OrderBy(e => e.Name).ToArray();
    }

    public Product GetById(string id)
    {
      return _context.Products.FirstOrDefault(e => e.ID == id);
    }
  }
}
