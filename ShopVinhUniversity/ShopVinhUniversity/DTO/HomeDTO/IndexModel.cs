using ShopVinhUniversity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopVinhUniversity.DTO.HomeDTO
{
  public class IndexModel
  {
    public List<Product> Products { get; set; }
    public List<Category> Categories { get; set; }
    public Category ActiveCategory { get; set; }
  }
}
