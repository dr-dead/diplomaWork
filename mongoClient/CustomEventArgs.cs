using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mongoClient
{
	public class PatientIdentityEventArgs : EventArgs
	{
		public string Id { get; private set; }
		public string Surname { get; private set; }
		public string Name { get; private set; }
		public string Patronymic { get; private set; }
		public PatientIdentityEventArgs(string id, string surname, string name, string patronymic)
		{
			Id = id;
			Surname = surname;
			Name = name;
			Patronymic = patronymic;
		}
	}
}
