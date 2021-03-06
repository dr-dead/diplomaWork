﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.DefaultSerializer;

namespace mongoClient
{
	class Patient : Person
	{
		[BsonDateTimeOptions(DateOnly = true)]
		[BsonIgnoreIfNull]
		public DateTime? DateOfDeath { get; set; }
		[BsonDefaultValue("", SerializeDefaultValue = false)]
		public string Address { get; set; }
		[BsonDefaultValue("", SerializeDefaultValue = false)]
		public string Telephone { get; set; }
		[BsonIgnoreIfNull]
		public ObjectId? CurrentMedic { get; set; }
		[BsonIgnoreIfNull]
		public ObjectId[] HealthLog { get; set; }
	}
}
