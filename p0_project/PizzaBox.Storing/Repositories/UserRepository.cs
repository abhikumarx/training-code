using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class UserRepository
  {
    public static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
    public static void GetPizzaOrder()
    {
      OrderRepository order = new OrderRepository();
      order.CreateOrder();
    }


  }
}