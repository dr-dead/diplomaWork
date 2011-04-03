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
		private string patronymic;
		public string Surname { get; set; }
		public string Name { get; set; }
		[BsonIgnoreIfNull]
		public string Patronymic { get { return patronymic; } set { if(value == String.Empty) value = null; patronymic = value; } }
		[BsonDateTimeOptions(DateOnly = true)]
		[BsonIgnoreIfNull]
		public DateTime? DateOfBirth { get; set; }

		public string GetInitials()
		{
			return Surname + " " + Name[0] + ". " + Patronymic[0] + ".";
		}
	}
}
