using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Storing.Repositories
{
  public class UserRepository
  {
    public static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();

    public List<User> GetUsers()
    {
     
      return _db.Users.Include(u => u.UserAddress).Include(u => u.UserName).Include(u => u.PhoneNumber).Include(u => u.EmailAddress).Include(u => u.userorders).ToList();
    }

    public User GetUsers(long id)
    {
      return _db.Users.SingleOrDefault(u => u.UserId == id);
    }
    // public static void GetPizzaOrder()
    // {
    //   OrderRepository order = new OrderRepository();
    //   order.CreateOrder();
    // }

    public bool PostUsers(User user)
    {
       _db.Users.Add(user);
      return _db.SaveChanges() == 1;
    }

    // public bool PutUsers(User user)
    // {
    //   var u = GetUsers(user.UserId);

    //   u = user;
    
    //   return _db.SaveChanges() == 1;
    // }



  }
}