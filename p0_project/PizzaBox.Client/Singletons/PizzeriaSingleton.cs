using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
  public class PizzeriaSingleton
  {
    private static readonly PizzaRepository _pr = new PizzaRepository();
    private static readonly PizzeriaSingleton _ps = new PizzeriaSingleton();

  public static PizzeriaSingleton Instance { 
    
    get
    {
      return _ps;
    }

    }
    private PizzeriaSingleton(){}
  
    //Only getting the list based on the user
    public List<Pizza> Get()
    {
      return _pr.Get();
    }

  //Creating pizza
    public bool Post(Crust crust, Size size, List<Topping> topping)
    {
     var p = new Pizza()
      {
        Crust = crust,
        Size = size,
       // Toppings = topping
      };

     return _pr.Post(p);
    }
  }
}