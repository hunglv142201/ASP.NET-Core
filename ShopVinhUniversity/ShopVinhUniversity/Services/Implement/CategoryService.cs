using ShopVinhUniversity.Data;
using ShopVinhUniversity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopVinhUniversity.Services.Implement
{
  public class CategoryService : ICategoryService
  {
    private readonly ApplicationDbContext _context;

    public CategoryService(ApplicationDbContext context)
    {
      _context = context;
    }

    public Category Create(Category category)
    {
      Category newCategory = new Category
      {
        ID = Guid.NewGuid().ToString(),
        CreatedTime = DateTime.Now.Ticks,
        UpdatedTime = DateTime.Now.Ticks,
        Title = category.Title
      };

      _context.Categories.Add(newCategory);
      _context.SaveChanges();

      return newCategory;
    }

    public void Delete(string id)
    {
      _context.Categories.Remove(GetById(id));
      _context.SaveChanges();
    }

    public ICollection<Category> GetAll(int page = 0, int size = 10)
    {
      return _context.Categories.OrderByDescending(e => e.CreatedTime).Skip(page * size).Take(size).ToArray();
    }

    public Category GetById(string id)
    {
      return _context.Categories.FirstOrDefault(e => e.ID == id);
    }

    public Category Update(Category category)
    {

      Category categoryToUpdate = GetById(category.ID);
      if (categoryToUpdate == null)
      {
        throw new Exception("Category not found");
      }

      categoryToUpdate.UpdatedTime = DateTime.Now.Ticks;
      categoryToUpdate.Title = category.Title;

      _context.SaveChanges();

      return categoryToUpdate;
    }
  }
}
