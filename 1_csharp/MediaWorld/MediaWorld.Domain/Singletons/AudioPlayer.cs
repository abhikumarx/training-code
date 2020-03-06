using System;
using MediaWorld.Domain.Abstract;

namespace MediaWorld.Domain.Singletons
{

// public static class AudioPlayer
// {
//   public static void Play()
//   {
//     Console.WriteLine("no");
//   }
// }
//
public class AudioPlayer : APlayer
{
  private static AudioPlayer _ap = new AudioPlayer();
  
  private AudioPlayer()
  {

  }

  public static AudioPlayer Instance
  {
    get
    {
      return _ap;
    }
  }

    // public static AudioPlayer GetInstance()
    // {
    //   return _ap;
    // }
  }
}