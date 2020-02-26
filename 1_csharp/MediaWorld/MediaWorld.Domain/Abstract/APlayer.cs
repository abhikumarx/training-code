using MediaWorld.Domain.Interfaces;
using System;

namespace MediaWorld.Domain.Abstract
{
  public abstract class APlayer : IPlayer
  {
    public void Play(AMedia media)
    {
      Console.WriteLine("{0} is being played....", media.Title);
    }

    public void Stop(AMedia media)
    {
      Console.WriteLine("{0} is being stopped...." , media.Title);
    }
  }
}