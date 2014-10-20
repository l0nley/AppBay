namespace AppBay.Console.Models
{
  public class Package : BaseCollectionEntity
  {
    public Package() : base("packages")
    {
    }

    public int PackageId { get; set; }
    public string Description { get; set; }
    public string TargetClassName { get; set; }
  }
}