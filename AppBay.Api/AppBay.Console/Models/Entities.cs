using System;
using System.Data.Services;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace AppBay.Console.Models
{
  public class Entities : IUpdatable
  {
    public IQueryable<JobDescription> Jobs
    {
      get
      {
        return GetDb().GetCollection<JobDescription>("jobs").AsQueryable();
      }
    }

    public IQueryable<Package> Packages
    {
      get
      {
        return GetDb().GetCollection<Package>("packages").AsQueryable();
      }
    }

    public IQueryable<JobResult> JobResults
    {
      get
      {
        return GetDb().GetCollection<JobResult>("results").AsQueryable();
      }
    }

    public object CreateResource(string containerName, string fullTypeName)
    {
      var t = GetEntityType(fullTypeName);
      var obj = Activator.CreateInstance(t);
      var coll = GetDb().GetCollection(t, containerName);
      coll.Insert(t, obj);
      return obj;
    }

    public object GetResource(IQueryable query, string fullTypeName)
    {
      throw new System.NotImplementedException();
    }

    public object ResetResource(object resource)
    {
      throw new System.NotImplementedException();
    }

    public void SetValue(object targetResource, string propertyName, object propertyValue)
    {
      throw new System.NotImplementedException();
    }

    public object GetValue(object targetResource, string propertyName)
    {
      throw new System.NotImplementedException();
    }

    public void SetReference(object targetResource, string propertyName, object propertyValue)
    {
      throw new System.NotImplementedException();
    }

    public void AddReferenceToCollection(object targetResource, string propertyName, object resourceToBeAdded)
    {
      throw new System.NotImplementedException();
    }

    public void RemoveReferenceFromCollection(object targetResource, string propertyName, object resourceToBeRemoved)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteResource(object targetResource)
    {
      throw new System.NotImplementedException();
    }

    public void SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public object ResolveResource(object resource)
    {
      throw new System.NotImplementedException();
    }

    public void ClearChanges()
    {
      throw new System.NotImplementedException();
    }

    private MongoDatabase GetDb()
    {
      var con = new MongoClient("mongodb://localhost");
      var server = con.GetServer();
      var db = server.GetDatabase("Jobs");
      return db;
    }

    private static Type GetEntityType(string fullName)
    {
      var some = Type.GetType(fullName);
      if (some == null)
      {
        throw new Exception("Type not found");
      }

      return some;
    }
  }
}