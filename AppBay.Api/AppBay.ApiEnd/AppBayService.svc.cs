using System;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel;
using AppBay.Classes.Models;
using MongoDB.Bson;
using MongoDB.Driver.Builders;

namespace AppBay.ApiEnd
{
  [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
  public class AppBayService : DataService<Entities>
  {
    public static void InitializeService(DataServiceConfiguration config)
    {
      config.SetEntitySetAccessRule("Jobs", EntitySetRights.All);
      config.SetEntitySetAccessRule("JobResults", EntitySetRights.AllRead);
      config.SetEntitySetAccessRule("Packages", EntitySetRights.All);
      config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
      config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
      config.UseVerboseErrors = true;
    }

    [ChangeInterceptor("Jobs")]
    public void OnJobDescriptionChanged(JobDescription description, UpdateOperations operations)
    {
      switch (operations)
      {
        case UpdateOperations.Add:
        case UpdateOperations.Change:
          if (description.IsRunning)
          {
            var q = Query.EQ("_id", new BsonString(description.Id));
            var item = CurrentDataSource.GetDb()
                .GetCollection<JobDescription>(description.CollectionName)
                .Find(q)
                .FirstOrDefault();
            if (item == null || item.IsRunning == false)
            {
              throw new InvalidOperationException("Property IsRunning cannot be set from client side");
            }
          }

          break;
        default:
          return;
      }
    }
  }
}
