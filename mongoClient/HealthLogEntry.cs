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
		[BsonDateTimeOptions(Kind=DateTimeKind.Local)]
		[BsonIgnoreIfNull]
		public DateTime AppointmentTime { get; set; }
		[BsonIgnoreIfNull]
		public ObjectId? ManagingMedic { get; set; }
		[BsonDefaultValue("", SerializeDefaultValue=false)]
		public string Direction { get; set; }
		[BsonDefaultValue("", SerializeDefaultValue=false)]
		public string Status { get; set; }
	}
}
