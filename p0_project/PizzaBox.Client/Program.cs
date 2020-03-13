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
      private static readonly CrustRepository _cr = new CrustRepository();
      private static readonly SizeRepository _sr = new SizeRepository();
      private static readonly StoreRepository _st = new StoreRepository();
        
      private static void Main(string[] args)
        {
          bool running = true;
          while(running)
          {
          LoadLocations();         
          GetAllPizzas();
          GetAlltheOrders();
          GetUser();
          }    

        }

        //To create a pizza
        private static void GetAllPizzas()
        {

        foreach(var p in _ps.Get())
        {
        Console.WriteLine(p);
        }
        }
        private static void GetAlltheOrders()
        {
          foreach(var o in _os.GetOrders())
          {
            Console.WriteLine(o);
          }
        }

        private static void CreatAPizza()
        {
          var p = new Pizza();

        }

      public static void PostAllPizzas()
      {
        var crusts = _cr.Get(); // _db1
      var sizes = _sr.Get(); // _db2

      _ps.Post(crusts[0], sizes[0], null);
        
      }
        

        public static void GetUser()
        {
          var u = new User();
          Console.WriteLine("Enter your name:");
          u.UserName = Console.ReadLine();
          Console.WriteLine("Enter your Address:");
          u.UserAddress = Console.ReadLine();
          Console.WriteLine("Enter your Phone Number:");
          u.PhoneNumber = Console.ReadLine();
          Console.WriteLine("Enter your Email:");
          u.EmailAddress = Console.ReadLine();
          
          _ur.PostUsers(u);
        }

      public static void LoadLocations()
      {
        Console.WriteLine("Select a location:");
       // s.StoreName = Console.ReadLine();
        Store[] starr = _st.GetStore().ToArray();
        Console.WriteLine("Select a location:");
        for(int i = 0; i < starr.Length; i++)
        {
          Console.WriteLine(starr[i].ToString());
        }
      }

        
    }
}
