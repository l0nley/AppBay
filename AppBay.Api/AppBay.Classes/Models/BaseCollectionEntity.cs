﻿using System.Data.Services.Common;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace AppBay.Classes.Models
{
  [DataServiceKey("Id")]
  public class BaseCollectionEntity
  {
    public BaseCollectionEntity(string collectionName)
    {
      CollectionName = collectionName;
    }

    [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
    public string Id { get; set; }

    public string CollectionName { get; private set; }
  }
}
