using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongoClient
{
	/// <summary>
	/// 
	/// </summary>
	public class ServerConnection
	{
		private static MongoServer server = null;

		private static bool connected = false;

		private static string databaseName = "";

		public ServerConnection(string serverSettings)
		{
			server = MongoServer.Create("mongodb://" + serverSettings);
		}

		public static MongoServer Server
		{
			get
			{
				return server;
			}
		}

		public static bool Connected
		{
			get
			{
				return connected;
			}
			set
			{
				connected = value;
			}
		}

		public static string DatabaseName
		{
			get
			{
				return databaseName;
			}
			set
			{
				databaseName = value;
			}
		}
	}
}
