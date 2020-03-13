using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Storing.Databases;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class CrustRepository
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();

    public List<Crust> Get()
    {
      return _db.Crusts.ToList();
    }

    public Crust Get(long id)
    {
      return _db.Crusts.SingleOrDefault(p => p.CrustId == id);
    }

    public bool Post(Crust Crust)
    {
      _db.Crusts.Add(Crust);
      return _db.SaveChanges() == 1;
    }

    public bool Put(Crust Crust)
    {
      Crust p = Get(Crust.CrustId);

      p = Crust;
      return _db.SaveChanges() == 1;
    }
  }
}