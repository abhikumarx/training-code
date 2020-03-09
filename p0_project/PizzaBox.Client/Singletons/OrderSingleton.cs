using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;
using System.Linq;

namespace PizzaBox.Client.Singletons
{
  public class OrderSingleton
  {
   private static readonly OrderRepository _or = new OrderRepository();
  private static readonly OrderSingleton _os = new OrderSingleton();

  public static OrderSingleton InstanceOrder
  {
    get
    {
      return _os;
    }
  }

  private OrderSingleton(){}
   public List<Order> GetOrders()
   {
     return _or.GetOrders();
   }

      //This is a 'Create' method for an Order
    public void OPost(List<OrderPizza> orderpizzas)
    {
      Order order = new Order()
      {
        OrderPizzas = orderpizzas
      };     
    }
  }
}