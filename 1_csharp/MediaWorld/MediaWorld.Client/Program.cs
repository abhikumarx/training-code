using System;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using MediaWorld.Storage;
using MediaWorld.Storage.Adapters;
using MediaWorld.Storage.Repositories;

namespace MediaWorld.Client
{
   internal class Program
    {
      private static void Main(string[] args)
        {
            //PlayAudio();
            FileAdapter.Write();
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

        try 
        {
            foreach(var item in ac.PList())
            {
                ap2.Play(item);
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
    }
}
