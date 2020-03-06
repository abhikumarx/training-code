using System.Linq;
using MediaWorld.Domain.Abstract;
using MediaWorld.Storage.Adapters;
using Xunit;

namespace MediaWorld.Testing.AudioTests
{
  public class ReadUnit
  {
    private IOrderedEnumerable<AMedia> fa = FileAdapter.Read("../../../../medialib.xml");
    [Fact]
    public void Test_ReturnsList()
    {
      
        //Arrange
        var sut = new FileAdapter();
        var expect = 4;

        //act
        var actual = fa;

        //Assert
        Assert.True(expect == actual.Count());
    }

    [Fact]
    public void Test_ReturnsNull()
    {
      var actual = fa;

      Assert.False(actual == null);
    }
  }
}