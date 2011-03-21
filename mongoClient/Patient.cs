using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongoClient
{
	class Patient
	{
		[MongoDB.Bson.DefaultSerializer.BsonId]
		public ObjectId Id { get; set; }
		public string name { get; set; }
		public int number { get; set; }
	}
}
