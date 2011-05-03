using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace mongoClient
{
	public class PersonIdentityEventArgs : EventArgs
	{
		public string Id { get; private set; }
		public string Surname { get; private set; }
		public string Name { get; private set; }
		public string Patronymic { get; private set; }
		//TODO: refactor many params
		public PersonIdentityEventArgs(string id, string surname, string name, string patronymic)
		{
			Id = id;
			Surname = surname;
			Name = name;
			Patronymic = patronymic;
		}
	}

	public class MedicIdentityEventArgs : PersonIdentityEventArgs
	{
		public string Profession { get; private set; }
		public string Category { get; private set; }
		public string Degree { get; private set; }
		public string Department { get; private set; }
		//TODO: refactor many params
		public MedicIdentityEventArgs(string id, string surname, string name, string patronymic, string profession, string category, string degree, string department)
			: base(id, surname, name, patronymic)
		{
			Profession = profession;
			Category = category;
			Degree = degree;
			Department = department;
		}
	}
}
