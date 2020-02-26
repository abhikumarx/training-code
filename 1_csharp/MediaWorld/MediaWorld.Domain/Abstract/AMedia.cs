namespace MediaWorld.Domain.Abstract
{
  public abstract class AMedia
  {
    //public string Title { get; set;} = "C#";
    public string Title{ get; set; }

    protected AMedia()
    {
      Title = "Revature";
    }
  }
}