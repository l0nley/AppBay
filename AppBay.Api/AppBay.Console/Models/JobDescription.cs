using System;
using System.Data.Services;
using System.Data.Services.Common;
using MongoDB.Bson;

namespace AppBay.Console.Models
{
  [DataServiceKey("JobId"), IgnoreProperties("Id")]
  public class JobDescription : EntityBase
  {
    public JobDescription()
    {
      CollectionName = "Jobs";
    }

    public ObjectId Id { get; set; }
    public int JobId { get; set; }
    public int PackageId { get; set; }
    public string Description { get; set; }
    public DateTime Added { get; set; }
    public DateTime? Started { get; set; }
    public bool IsRunning { get; set; }
  }
}