using System;

namespace AppBay.Console.Models
{
  public class JobDescription : BaseCollectionEntity
  {
    public JobDescription() : base("Jobs")
    {
    }

    public int PackageId { get; set; }
    public string Description { get; set; }
    public DateTime Added { get; set; }
    public DateTime? Started { get; set; }
    public bool IsRunning { get; set; }
  }
}