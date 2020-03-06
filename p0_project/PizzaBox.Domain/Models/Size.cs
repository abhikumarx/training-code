using PizzaBox.Domain.Abstracts;
using System;

namespace PizzaBox.Domain.Models
{
  public class Size : APizzaComponent
  {
      public long SizeId { get; set;}

      public Size()
      {
        SizeId = DateTime.Now.Ticks;
      }
  }
}