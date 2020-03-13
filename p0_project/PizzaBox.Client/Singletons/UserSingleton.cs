using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
  public class UserSingleton

  {
    private static readonly UserRepository _ur = new UserRepository();
    private static readonly UserSingleton _us = new UserSingleton();
    public static UserSingleton InstanceUser { get{ return _us;} }
    private UserSingleton(){}

    public List<User> GetUsers()
    {
      return _ur.GetUsers();
    }

    public bool PostUsers(List<Order> orders)
    {
     var u = new User()
      {       
      
      };

     return _ur.PostUsers(u);
    }
  }

}