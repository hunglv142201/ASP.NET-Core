﻿using ShopVinhUniversity.Entities;
using System.Collections.Generic;

namespace ShopVinhUniversity.Services
{
  public interface IProductService
  {
    ICollection<Product> GetAll(int page = 0, int size = 10);

    Product GetById(string id);
  }
}
