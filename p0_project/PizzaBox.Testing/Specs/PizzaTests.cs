using PizzaBox.Storing.Repositories;
using Xunit;
using PizzaBox.Domain.Models;

namespace PizzaBox.Testing.Specs
{
  public class PizzaTests
  {
    //This method is testing the method get from repository.
    [Fact]
    public void Test_RepositoryGet()
    {
      //
      var sut = new PizzaRepository();
      var actual = sut.Get();

    //equals check on the value itself
    //same checks on types

    Assert.True(actual != null);
    Assert.True(actual.Count >= 0);
    
    }

    
  }
}