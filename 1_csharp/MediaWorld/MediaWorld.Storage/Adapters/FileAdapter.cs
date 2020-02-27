using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using MediaWorld.Domain.Abstract;

namespace MediaWorld.Storage.Adapters
{
  public class FileAdapter
  {
    //literal string meaning use it as is dont change
    private static string path = @"../medialib.xml";

    private static string pathw = @"../medialibw.xml";
    public static IEnumerable<AMedia> Read()
    {
      // to get to the file
      //serliazlization
      var reader = new StreamReader(path);
      var xml = new XmlSerializer(typeof(List<AMedia>));
      var la = xml.Deserialize(reader) as List<AMedia>;

      return la;

      //return new List<AMedia>();
    }

    public static void Write()
    {
      var writer = new StreamWriter(path);
      var xml = new XmlSerializer(typeof(List<AMedia>));
      var lib = new List<AMedia>(){ new Song()};
    }
  }
}