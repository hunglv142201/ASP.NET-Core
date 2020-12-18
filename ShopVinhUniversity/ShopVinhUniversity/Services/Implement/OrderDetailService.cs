using ShopVinhUniversity.Data;
using ShopVinhUniversity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopVinhUniversity.Services.Implement
{
  public class OrderDetailService : IOrderDetailService
  {
    private readonly ApplicationDbContext _context;

    public OrderDetailService(ApplicationDbContext context)
    {
      _context = context;
    }

    public OrderDetail Create(OrderDetail orderDetail)
    {
      OrderDetail newOrderDetail = new OrderDetail
      {
        ID = Guid.NewGuid().ToString(),
        CreatedTime = DateTime.Now.Ticks,
        UpdatedTime = DateTime.Now.Ticks,
        Amount = orderDetail.Amount,
        ProductID = orderDetail.ProductID,
        Status = orderDetail.Status,
        Purchaser = orderDetail.Purchaser,
        PhoneNumber = orderDetail.PhoneNumber,
        Address = orderDetail.Address
      };

      _context.OrderDetails.Add(newOrderDetail);
      _context.SaveChanges();

      return newOrderDetail;
    }

    public void Delete(string id)
    {
      _context.OrderDetails.Remove(GetById(id));
      _context.SaveChanges();
    }

    public ICollection<OrderDetail> GetAll(int page = 0, int size = 10)
    {
      return _context.OrderDetails.OrderByDescending(e => e.CreatedTime).Skip(page * size).Take(size).ToArray();
    }

    public OrderDetail GetById(string id)
    {
      return _context.OrderDetails.FirstOrDefault(e => e.ID == id);
    }

    public OrderDetail Update(OrderDetail orderDetail)
    {
      OrderDetail orderDetailToUpdate = GetById(orderDetail.ID);
      if (orderDetailToUpdate == null)
      {
        throw new Exception("OrderDetail not found");
      }

      orderDetailToUpdate.UpdatedTime = DateTime.Now.Ticks;
      orderDetailToUpdate.Amount = orderDetail.Amount;
      orderDetailToUpdate.ProductID = orderDetail.ProductID;
      orderDetailToUpdate.Status = orderDetail.Status;
      orderDetailToUpdate.Purchaser = orderDetail.Purchaser;
      orderDetailToUpdate.PhoneNumber = orderDetail.PhoneNumber;
      orderDetailToUpdate.Address = orderDetail.Address;

      _context.SaveChanges();

      return orderDetailToUpdate;
    }
  }
}
