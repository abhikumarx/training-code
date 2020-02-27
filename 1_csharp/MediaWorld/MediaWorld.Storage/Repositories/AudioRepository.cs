using System.Collections.Generic;
using MediaWorld.Domain.Abstract;
using MediaWorld.Storage.Adapters;

namespace MediaWorld.Storage.Repositories
{
  public class AudioRepository 
  {
    //Readoonly is a only created at construction
    //
    private readonly List<AMedia> _lib ;

    public AudioRepository()
    {
      if(_lib == null)
      {
        //the following is the way to read a file
        //you can cast using the FileAdapter.Read() as List<AMedia>;
        _lib = FileAdapter.Read() as List<AMedia>;
      }
    }

    public IEnumerable<AMedia> PList()
    {
      return _lib;
    }
  }
}