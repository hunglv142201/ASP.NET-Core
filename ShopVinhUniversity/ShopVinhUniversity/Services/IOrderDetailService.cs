using ShopVinhUniversity.Entities;
using System.Collections.Generic;

namespace ShopVinhUniversity.Services
{
  public interface IOrderDetailService
  {
    ICollection<OrderDetail> GetAll(int page = 0, int size = 10);

    OrderDetail GetById(string id);

    OrderDetail Create(OrderDetail orderDetail);

    OrderDetail Update(OrderDetail orderDetail);

    void Delete(string id);
  }
}
