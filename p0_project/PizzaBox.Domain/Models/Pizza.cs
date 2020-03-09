using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Domain.Models
{
  //Pizza is a business logic
  //
  public class Pizza 
  {
    //we;re giving this property id because we want the out of proc to be identifier to an identifier
    public long PizzaId {get; set;}
    public string Name { get; set;}

    //need to only compute the price therefore only get method
    public decimal Price { 

      get
      {
        if(Crust == null || Size == null || PizzaToppings == null)
        {        
         // decimal _price  = Crust.Price + Size.Price;

          // foreach(var t in Toppings)
          // {
          //   _price += t.Price;
          // }
          return 0;
        }

        return Crust.Price + Size.Price + PizzaToppings.Sum(pt => pt.Topping.Price);
      }
    }

    public Crust Crust { get;set;}
    public Size Size { get; set;}
    public List<PizzaTopping> PizzaToppings { get; set;}

    public Pizza()
    {
     
    }

    public override string ToString()
    {
      //got the error because the values of the name were null and it's not a representation of string so you have write what it should say
      return $"{PizzaId} {Name ?? "N/A"} {Price} {Crust.Name ?? "N/A" } {Size.Name ?? "N/A"} {PizzaToppings.Count}";
    }
  }
}
