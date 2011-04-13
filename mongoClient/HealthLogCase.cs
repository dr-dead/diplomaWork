using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.DefaultSerializer;

namespace mongoClient
{
	class HealthLogCase
	{
		[BsonId]
		public ObjectId Id { get; set; }
		[BsonDefaultValue("", SerializeDefaultValue = false)]
		public string number { get; set; }
		[BsonIgnoreIfNull]
		public ObjectId[] HealthLogEntries { get; set; }
	}
}
