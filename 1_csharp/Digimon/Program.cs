using System;

namespace Digimon
{

  public class Digimon{

  }

  public class Calculation{

  

  }

  public class Program 
  {

    private static void Main(string[] args)
    {
      var p = new Program();
      p.Fight(null, null);
    }
   
    public void Fight(Digimon a, Digimon b)
    {
      Console.WriteLine("{0} fights {1}", a, b);
    }

    public int Multiply(Calculation a, Calculation b)
    {
      Console.WriteLine("Enter a number:" , a , b);
      return 5;
    }

  }
}
