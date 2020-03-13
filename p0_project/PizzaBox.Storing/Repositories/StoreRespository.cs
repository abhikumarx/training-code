using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class StoreRepository
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();

    public List<Store> GetStore()
    {
       return _db.stores.Include(s=> s.StoreId).Include(s =>s.StoreName).Include(s =>s.StoreAddress).Include(s =>s.PhoneNum).ToList();
    }

    public Store GetStore(long id)
    { 
      return _db.stores.SingleOrDefault(s => s.StoreId == id);
    }

    public bool PostStore(Store store)
    {
       _db.stores.Add(store);
      return _db.SaveChanges() == 1;
    }

    public bool PutStore(Store store)
    {
      var s = GetStore(store.StoreId);
      s = store;
      return _db.SaveChanges() == 1;
    }
  }
}