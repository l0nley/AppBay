using System.Data.Services;
using System.Data.Services.Common;
using MongoDB.Bson;

namespace AppBay.Console.Models
{
  [DataServiceKey("PackageId"), IgnoreProperties("Id")]
  public class Package : EntityBase
  {
    public Package()
    {
      CollectionName = "Packages";
    }

    public ObjectId Id { get; set; }
    public int PackageId { get; set; }
    public string Description { get; set; }
    public string TargetClassName { get; set; }
  }
}