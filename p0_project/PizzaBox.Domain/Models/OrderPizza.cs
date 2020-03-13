using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class OrderPizza
  {
    public long OrderId { get; set; }
    public Order order { get; set; }
    public long PizzaId { get; set; }
    public Pizza Pizza { get; set; }

  }
}