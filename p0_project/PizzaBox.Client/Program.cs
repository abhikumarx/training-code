using System;
using System.Collections.Generic;
using PizzaBox.Client.Singletons;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
    internal class Program
    { 
      private static readonly PizzaRepository _pr = new PizzaRepository();
      private static readonly OrderRepository _or = new OrderRepository();
      private static readonly PizzeriaSingleton _ps = PizzeriaSingleton.Instance;
      private static readonly OrderSingleton _os = OrderSingleton.InstanceOrder;
      private static readonly UserRepository _ur = new UserRepository();
      private static readonly UserSingleton _us = UserSingleton.InstanceUser;
        private static void Main(string[] args)
        {
          // GetAllPizzas();
          // GetTheOrder();
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

      public static void PostAllPizzas()
      {
        //this is used to get the crust
        
      }
        // private static void GetTheOrder()
        // {
        //   User o1 = new User();
        //   foreach(var o in _us.Get())
        //   {
            
        //    if(o.OrderId != 0)
        //    {
        //      Console.WriteLine("Your First order was placed with Id:{0}", o.OrderId);
        //      Console.WriteLine("Your First order was placed with Id:{1}", o.OrderId);
        //    }
        //   }
        // }

        
    }
}
