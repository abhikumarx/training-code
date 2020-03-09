using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
  public class UserSingleton

  {
    private static readonly UserRepository _ur = new UserRepository();
    private static readonly UserSingleton _us = new UserSingleton();
    public static UserSingleton InstanceUser { get{ return _us;} }
    private UserSingleton(){}
  }

}