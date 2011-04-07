using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.DefaultSerializer;

namespace mongoClient
{
	[BsonKnownTypes(typeof(Patient), typeof(Medic))]
	class Person
	{
		[BsonId]
		public ObjectId Id { get; set; }
		public string Surname { get; set; }
		public string Name { get; set; }
		[BsonDefaultValue("", SerializeDefaultValue = false)]
		public string Patronymic { get; set; }
		[BsonDateTimeOptions(DateOnly = true)]
		[BsonIgnoreIfNull]
		public DateTime? DateOfBirth { get; set; }

		public string GetInitials()
		{
			return Surname + " " + Name[0] + ". " + Patronymic[0] + ".";
		}
	}
}
