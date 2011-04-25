using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.DefaultSerializer;

namespace mongoClient
{
	class Medic : Person
	{
		[BsonDefaultValue("", SerializeDefaultValue = false)]
		public string Profession { get; set; }
		[BsonDefaultValue("", SerializeDefaultValue = false)]
		public string Degree { get; set; }
		[BsonDefaultValue("", SerializeDefaultValue = false)]
		public string Category { get; set; }
		[BsonDefaultValue("", SerializeDefaultValue = false)]
		public string Department { get; set; }
		[BsonIgnoreIfNull]
		public int? Cabinet { get; set; }
		[BsonDefaultValue(true, SerializeDefaultValue = false)]
		public bool IsWorking { get; set; }
	}
}
