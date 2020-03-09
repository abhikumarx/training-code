using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class OrderRepository
  {
 //   private static readonly List<Order> _op = new List<Order>();
    public static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
   
    public List<Order> GetOrders()
    {
      return _db.Orders.ToList();
    }

    //Get the Pizzas associated with the order
    public Order GetOrder(long id)
    {
      return _db.Orders.SingleOrDefault(o => o.OrderId == id);
    }

      //This is a 'Create' method for an Order
      public void CreateOrder()
      {
        var o = new PizzaRepository();
        o.Get(1);
        
      } 

    public void OPost(Order order)
    {
      _db.Orders.Add(order);
     _db.SaveChanges();
    }

    public void oPut(Order order)
    {
      var o = GetOrder(order.OrderId);
      o = order;
      _db.SaveChanges();
    }
  }
}