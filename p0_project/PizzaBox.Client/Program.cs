using System;
using System.Collections.Generic;
using PizzaBox.Client.Singletons;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
    internal class Program
    {
      //
      //private static readonly PizzaRepository _pr = new PizzaRepository();
      private static readonly PizzeriaSingleton _ps = PizzeriaSingleton.Instance;
        private static void Main(string[] args)
        {
           GetAllPizzas();
        }

        //To create a pizza
        private static void GetAllPizzas()
        {
           //because we are expecting a type of Pizza
          // var lp = new List<Pizza>()

           //Creating some pizzas or Creating a pizza
          //  {
          //   new Pizza()
          //  };

          //
            foreach(var p in _ps.Get())
           {
              Console.WriteLine(p);
          }
        }

        private static void GetTheOrder()
        {
          
        }
    }
}
