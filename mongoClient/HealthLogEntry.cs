using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.DefaultSerializer;

namespace mongoClient
{
	class HealthLogEntry
	{
		[BsonId]
		public ObjectId Id { get; set; }
	}
}
