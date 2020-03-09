using PizzaBox.Domain.Abstracts;
using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Size : APizzaComponent
  {
      public long SizeId { get; set;}
      public List<Pizza> Pizzas { get;set;}

      public Size()
      {
        SizeId = DateTime.Now.Ticks;
      }
  }
}