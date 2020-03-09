using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Order 
  {
   
    public long OrderId { get; set; }
   // public int OrderNumber { get; set; } //this is static for now
    public DateTime OrderDate { get; set; }
    public decimal OrderTotal { 
      get
      {
          if(OrderPizzas == null)
          {
            return 0;
          }
            var p = new Pizza();       
          return p.Price + OrderTotal;
      }         
    }
    public List<OrderPizza> OrderPizzas { get; set; }

    public Order()
    {
      OrderId = 22;
    }

    public override string ToString()
    {
      
      return $"{OrderId} {OrderDate} {OrderTotal} {OrderPizzas.Count}";
    }
  }
}