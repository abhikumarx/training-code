using System.Collections.Generic;
using MediaWorld.Domain.Abstract;

namespace MediaWorld.Storage.Repositories
{
  public class AudioRepositoriesGeneric<T> where T : AAudio
  {
    private static readonly List<T> _lib = new List<T>();
    
  }
}
