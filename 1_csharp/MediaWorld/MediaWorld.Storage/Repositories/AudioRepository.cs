using System.Collections.Generic;
using MediaWorld.Domain.Abstract;
using MediaWorld.Domain.Models;
using MediaWorld.Storage.Adapters;

namespace MediaWorld.Storage.Repositories
{
  public class AudioRepository 
  {
    //Readoonly is a only created at construction
    //
    private static readonly List<AAudio> _lib  = new List<AAudio>()
    {
        new Song()
        {
            Title = "Song 1"            
        },
        new Song(){
          Title = "Song 2"
        },
        new Book(){
          Title = "Book 1"
        },
        new Book(){
          Title = "Book 2"
        }
    };

    public AudioRepository()
    {
      // if(_lib == null)
      // {
        //the following is the way to read a file
        //you can cast using the FileAdapter.Read() as List<AMedia>;
      //   _lib = FileAdapter.Read() as List<AMedia>;
      // }
    }

    public IEnumerable<AMedia> PList()
    {
      return _lib;
    }
  }
}