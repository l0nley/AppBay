using System;
using System.Collections;
using System.Data.Services;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace AppBay.Classes.Models
{
  public class Entities : IUpdatable
  {
    private readonly object _lock = new object();

    private MongoDatabase _cachedDatabase;

    public IQueryable<JobDescription> Jobs
    {
      get { return GetDb().GetCollection<JobDescription>("Jobs").AsQueryable(); }
    }

    public IQueryable<Package> Packages
    {
      get
      {
        return GetDb().GetCollection<Package>("Packages").AsQueryable();
      }
    }

    public IQueryable<JobResult> JobResults
    {
      get
      {
        return GetDb().GetCollection<JobResult>("Results").AsQueryable();
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
      var b = query.Provider.Execute(query.Expression);
      if (!(b is IEnumerable))
      {
        return b;
      }

      var enumerator = (b as IEnumerable).GetEnumerator();
      enumerator.MoveNext();
      var c = enumerator.Current;
      return c;
    }

    public object ResetResource(object resource)
    {
      throw new NotImplementedException();
    }

    public void SetValue(object targetResource, string propertyName, object propertyValue)
    {
      if (propertyName == "IsRunning")
      {
        return;
      }

      var entity = targetResource as BaseCollectionEntity;
      if (entity == null)
      {
        throw new Exception("Entity type not supported");
      }

      var resourceType = targetResource.GetType();
      var prop = resourceType.GetProperty(propertyName);
      prop.SetValue(targetResource, propertyValue);
      var collection = GetDb().GetCollection(resourceType, entity.CollectionName);
      var q = Query.EQ("_id", new BsonString(entity.Id));
      var u = Update.Set(propertyName, GetBsonValue(prop.PropertyType, propertyValue));
      collection.Update(q, u);
    }

    public object GetValue(object targetResource, string propertyName)
    {
      throw new NotImplementedException();
    }

    public void SetReference(object targetResource, string propertyName, object propertyValue)
    {
      throw new NotImplementedException();
    }

    public void AddReferenceToCollection(object targetResource, string propertyName, object resourceToBeAdded)
    {
      throw new NotImplementedException();
    }

    public void RemoveReferenceFromCollection(object targetResource, string propertyName, object resourceToBeRemoved)
    {
      throw new NotImplementedException();
    }

    public void DeleteResource(object targetResource)
    {
      throw new NotImplementedException();
    }

    public void SaveChanges()
    {
      // Nothing. Just going thru.
    }

    public object ResolveResource(object resource)
    {
      // No special processing needed in this case // TODO Check on update
      return resource;
    }

    public void ClearChanges()
    {
      throw new NotImplementedException();
    }

    public MongoDatabase GetDb()
    {
      if (_cachedDatabase != null)
      {
        return _cachedDatabase;
      }

      lock (_lock)
      {
        var con = new MongoClient("mongodb://localhost");
        var server = con.GetServer();
        _cachedDatabase = server.GetDatabase("Jobs");
      }

      return _cachedDatabase;
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

    private static BsonValue GetBsonValue(Type propertyType, object value)
    {
      if (value == null)
      {
        return BsonNull.Value;
      }

      if (propertyType == typeof(string))
      {
        return new BsonString(string.Format("{0}", value));
      }

      if (propertyType == typeof(long))
      {
        return new BsonInt64((long)value);
      }

      if (propertyType == typeof(int))
      {
        return new BsonInt32((int)value);
      }

      if (propertyType == typeof(DateTime) || propertyType == typeof(DateTime?))
      {
        return new BsonDateTime((DateTime)value);
      }

      if (propertyType == typeof(bool))
      {
        return new BsonBoolean((bool)value);
      }

      throw new Exception("Requested property type is not supported");
    }
  }
}