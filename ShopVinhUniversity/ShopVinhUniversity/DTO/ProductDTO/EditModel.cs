using ShopVinhUniversity.Entities;
using System.Collections.Generic;

namespace ShopVinhUniversity.DTO.ProductDTO
{
  public class EditModel
  {
    public Product Product { get; set; }
    public List<Category> Categories { get; set; }
  }
}
