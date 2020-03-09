using PizzaBox.Domain.Abstracts;
using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Crust: APizzaComponent
  {
      public long CrustId{ get;set;}
      public List<Pizza> Pizzas{get; set;}
      public Crust()
      {
        CrustId = DateTime.Now.Ticks;
      }
  }
}