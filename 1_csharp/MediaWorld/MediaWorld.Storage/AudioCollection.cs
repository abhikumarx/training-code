using System;
using MediaWorld.Domain.Abstract;
using System.Collections.Generic;
using MediaWorld.Domain.Models;

namespace MediaWorld.Storage
{
  public class AudioCollection
  {
    private AMedia[] _audioArray;
    private List<AMedia> _audioList;
    private Dictionary<string, AMedia> _audioDictionary;

  //need to create this for object instantiation for the specific songs
   public AudioCollection()
   {
     // we assigned the value to _audioArray
     //we need to give it content rather then size
    // _audioArray = new AMedia[1];

     _audioArray = new AMedia[]{ new Song()};
     
   }

    //We're only expecting one list from the following list
    public IEnumerable<AMedia> PlayList()
    {
      return _audioArray;
    }
  }
}