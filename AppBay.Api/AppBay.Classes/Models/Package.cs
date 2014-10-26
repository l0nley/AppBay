namespace AppBay.Classes.Models
{
  public class Package : BaseCollectionEntity
  {
    public Package() : base("Packages")
    {
    }

    public int PackageId { get; set; }
    public string Description { get; set; }
    public string TargetClassName { get; set; }
    public byte[] Payload { get; set; }
  }
}