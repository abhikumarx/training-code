using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Storing.Repositories
{
  public class OrderRepository
  {
 //   private static readonly List<Order> _op = new List<Order>();
    public static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
   
    public List<Order> GetOrdersRepo()
    {
      //this is going to return a list of orders from the database which includes 
      return _db.Orders.Include(o =>o.OrderDate).Include(o => o.OrderTotal).Include(o => o.OrderPizzas).ToList();
    }

  
    public Order GetOrder(long id)
    {
      //this method is going to return a Order after getting it from the database since the Order is the 'datatype' 
      return _db.Orders.SingleOrDefault(o => o.OrderId == id) ;
    }

      //This is a 'Create' method for an Order
      // public void CreateOrder()
      // {
      //   var o = new PizzaRepository();
      //   o.Get(1);
        
      // } 

    //Associating the list of orders with the store
      // public List<Order> GetOrders(Store store)
      // {
      //   return GetOrders().Where(ord => ord.stores.StoreId == store.StoreId).ToList();
      // }

    public bool OPost(Order order)
    {
      _db.Orders.Add(order);
    return _db.SaveChanges() == 1;
    }

    public bool oPut(Order order)
    {
      var o = GetOrder(order.OrderId);
      o = order;
      return _db.SaveChanges() == 1;
    }
  }
}