using ShopVinhUniversity.Entities;
using System.Collections.Generic;

namespace ShopVinhUniversity.Services
{
  public interface ICategoryService
  {
    ICollection<Category> GetAll(int page = 0, int size = 10);

    Category GetById(string id);

    Category Create(Category category);

    Category Update(Category category);

    void Delete(string id);
  }
}
