using System;
using System.Data.Services;
using System.Data.Services.Common;
using MongoDB.Bson;

namespace AppBay.Console.Models
{
  [DataServiceKey("JobResultId"), IgnoreProperties("Id")]
  public class JobResult : EntityBase
  {
    public JobResult()
    {
      CollectionName = "JobResults";
    }

    public ObjectId Id { get; set; }
    public int JobResultId { get; set; }
    public string Description { get; set; }
    public DateTime Started { get; set; }
    public DateTime Finished { get; set; }
    public bool IsSuccess { get; set; }
    public string ErrorMessage { get; set; }
    public string SerializedResult { get; set; }
  }
}