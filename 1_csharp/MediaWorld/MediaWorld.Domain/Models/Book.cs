using System.Threading;
using MediaWorld.Domain.Abstract;

namespace MediaWorld.Domain.Models
{
  public class Book: AAudio
  {
    public delegate void CasingDelegate(string s);
    public delegate void CasingDelegate2();

    public event CasingDelegate BookEvent;

      public void Read(HowToRead r)
      {
          var text = "Read The Book";

          switch(r)
          {
            
          }
      }

     

      public void ReadDelegate(CasingDelegate d)
      {
      var text = "read from delegate";

      d(text);
      }

      public void ReadDelegate2(CasingDelegate2 d)
      {
        d();
      }
      
      public void Open()
      {
        if(BookEvent != null)
        {
          var count = 0;
          while(count < 10)
          {
            this.BookEvent("someone opened a book");
            Thread.Sleep(1000);
            count += 1;
          }
        }
        
      }

  } 
  public enum HowToRead
      {
          Upper,

          Lower,
      }
}