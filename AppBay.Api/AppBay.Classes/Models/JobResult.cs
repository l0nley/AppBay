using System;

namespace AppBay.Classes.Models
{
  public class JobResult : BaseCollectionEntity
  {
    public JobResult() : base("Results")
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