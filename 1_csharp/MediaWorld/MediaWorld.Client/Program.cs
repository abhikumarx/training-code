using System;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;

namespace MediaWorld.Client
{
   internal class Program
    {
      private static void Main(string[] args)
        {
            PlayAudio();
        }

        private static void PlayAudio()
        {        
         // Console.WriteLine(ap);
        //  AudioPlayer.Play();
       // var ap = AudioPlayer.GetInstance();
        var ap2 = AudioPlayer.Instance;
        var s = new Song();

        ap2.Play(s);
        }

        private static void PlayVideo()
        {
         // var vp = VideoPlayer.GetInstance();
          var vp2 = VideoPlayer.Instance;
        }
    }
}
