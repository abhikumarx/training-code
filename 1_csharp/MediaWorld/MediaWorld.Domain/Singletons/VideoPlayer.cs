
namespace MediaWorld.Domain.Singletons
{

public class VideoPlayer
{
  private static VideoPlayer _vp = new VideoPlayer();

  public static VideoPlayer Instance
  {
    get{
      return _vp;
    }
  }
  private VideoPlayer()
  {

  

  }

  public static VideoPlayer GetInstance()
  {
    return _vp;
  }
}

}
