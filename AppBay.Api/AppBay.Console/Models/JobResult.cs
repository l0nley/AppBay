using System;
using System.Data.Services.Common;

namespace AppBay.Console.Models
{
  public class JobResult : BaseCollectionEntity
  {
    public JobResult() : base("results")
    {
    }

    public string Description { get; set; }
    public DateTime Started { get; set; }
    public DateTime Finished { get; set; }
    public bool IsSuccess { get; set; }
    public string ErrorMessage { get; set; }
    public string SerializedResult { get; set; }
  }
}