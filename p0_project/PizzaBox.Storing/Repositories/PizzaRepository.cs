using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaRepository
  {
    //To the client this is the real data store
    //private static readonly List<Pizza> _lp = new List<Pizza>();
    
    // public List<Pizza> Get()
    // {
      //What does this do?
    //   return new List<Pizza>()
    //   {
    //     new Pizza()
    //   };
    // }

  private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
  
    public List<Pizza> Get()
    {
      
    //   return _db.Pizzas.ToList();  
      //types of loading
      //Eager loading physically defining the proj
     // return _db.Pizzas.Include("Crust").Include("Size").Include("Toppings").ToList();
     //Instance loading
     //this is returning the list of pizzas from the database?
     return _db.Pizzas.Include(p =>p.Crust).Include(p => p.Size).Include(p => p.PizzaToppings).ToList();
    }

  //Get the pizza
    public Pizza Get(long id)
    {
      //return _db.Pizzas.FirstOrDefault(p => p.PizzaId);
      return _db.Pizzas.SingleOrDefault(p => p.PizzaId == id);
    }

    //save a pizza
    public bool Post(Pizza pizza)
    {
       _db.Pizzas.Add(pizza);
      return _db.SaveChanges() == 1;

    }

  //Update method
    public bool Put(Pizza pizza)
    {
      var p = Get(pizza.PizzaId);

      p = pizza;
    
      return _db.SaveChanges() == 1;
    }

    //Delete Method
    // public bool Remove(Pizza pizza)
    // {
    //   var p = Get(pizza.PizzaId);

    //   p = pizza;
    //   _db.Pizzas.Remove(pizza);
    //   return _db.SaveChanges() == 1;
    // }

  }
}