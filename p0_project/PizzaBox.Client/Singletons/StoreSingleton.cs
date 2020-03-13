using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
  public class StoreSingleton
  {
    private static readonly StoreRepository _sr = new StoreRepository();
    private static readonly StoreSingleton _ss = new StoreSingleton();

    public static StoreSingleton InstanceStore { 
  
    get { return _ss;} }

    private StoreSingleton(){}

    public List<Store> GetStore()
    {
      return _sr.GetStore();
    }

    public bool PostStore()
    {
     var s = new Store()
      {       
      };
     return _sr.PostStore(s);
    }
  }
}