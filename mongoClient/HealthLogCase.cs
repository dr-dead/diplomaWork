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
		[BsonIgnoreIfNull]
		public ObjectId[] HealthLogEntries { get; set; }
		[BsonIgnoreIfNull]
		public ObjectId? ManagingMedic { get; set; }
		[BsonDateTimeOptions(DateOnly=true)]
		public DateTime StartDate { get; set; }
		[BsonIgnoreIfNull]
		[BsonDateTimeOptions(DateOnly=true)]
		public DateTime? EndDate { get; set; }
		[BsonDefaultValue(0, SerializeDefaultValue=false)]
		public int Height { get; set; }
		[BsonDefaultValue(0, SerializeDefaultValue=false)]
		public int Weight { get; set; }
		[BsonDefaultValue("", SerializeDefaultValue=false)]
		public string Diagnosis { get; set; }
		[BsonDefaultValue("", SerializeDefaultValue=false)]
		public string Complaints { get; set; }
	}
}
