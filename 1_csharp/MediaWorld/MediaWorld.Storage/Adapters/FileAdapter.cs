using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using MediaWorld.Domain.Abstract;
using MediaWorld.Domain.Models;

namespace MediaWorld.Storage.Adapters
{
  public class FileAdapter
  {
    //literal string meaning use it as is dont change
    private static string path = @"../medialib.xml";
    
    public static IEnumerable<AMedia> Read()
    {
      // to get to the file
      //serliazlization
      var reader = new StreamReader(path);
      var xml = new XmlSerializer(typeof(List<AMedia>));
      return xml.Deserialize(reader) as List<AMedia>;


      //return new List<AMedia>();
    }

    public static bool Write(List<AMedia> lib)
    {
      using(var writer = new StreamWriter(path))
      {
         
      //xmlserializer doesnt understand the concept of AMedia since its an abstract class
      var xml = new XmlSerializer(typeof(List<AMedia>), new[]{typeof(Book), typeof(Song)});
     
       xml.Serialize(writer, lib);

      return true;
      }
    }
  }
}