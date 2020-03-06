using System;
using System.Linq;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using MediaWorld.Storage;
using MediaWorld.Storage.Adapters;
using MediaWorld.Storage.Repositories;

namespace MediaWorld.Client
{
   internal class Program
    {
      private static readonly AudioRepository _ar = new AudioRepository();
      private static void Main(string[] args)
        {
           PlayAudio();
           //LINQ
           //FileAdapter.Write(_ar.PList().ToList());
        }

        private static void PlayAudio()
        {        
         // Console.WriteLine(ap);
        //  AudioPlayer.Play();
       // var ap = AudioPlayer.GetInstance();

       //created an object for AudioPlayer class in order to have one Audioplayer object
        var ap2 = AudioPlayer.Instance;

        //created an object for AudioCollection class
        //var ac = new AudioCollection();

        // if(ac.PlayList() != null)
        // {      
        // foreach(var item in ac.PlayList())
        //   {
        //     ap2.Play(item);
        //   }
        // }

        var ac = new AudioRepository();
        var ac2 = new AudioRepositoriesGeneric<Song>();
        
        try 
        {
            foreach(var item in ac.PList())
            {
                ap2.Play(item);
                ap2.Stop(item);
            }
        }
        catch(NullReferenceException err)
        {
          //specific to general
          Console.WriteLine("No Song for you", err);
        }
        catch(IndexOutOfRangeException err)
        {
          Console.WriteLine("No Song for you", err);
        }
        catch(Exception ex)
        {
          throw new Exception("error", ex);
        }
        //Final doesn't run if its a fatal exception
        finally
        {
            GC.Collect();
        }
      }
      
        private static void PlayVideo()
        {
         // var vp = VideoPlayer.GetInstance();
          var vp2 = VideoPlayer.Instance;
        }

      private static void PlayBook()
      {
        var b = new Book();

        //delegate part 2
        // b.ReadDelegate(UseCasingDelegate);
        // b.ReadDelegate2(UseCasingDelegate2);

        //event i want the playbook to know if there's an event
        b.BookEvent += UseEvent;
        b.Open();
      }

      public static void UseEvent(string s)
      {
        Console.WriteLine("WE HEARD YOU!!");
      }
        private static void UseCasingDelegate(string s)
        {
          Console.WriteLine(s);
        }

        private static string UseCasingDelegate2()
        {
          return "delegate rules!?";
        }
    }
}
