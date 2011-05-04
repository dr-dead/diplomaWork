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

		private static MongoCredentials credentials;

		public ServerConnection(MongoConnectionStringBuilder serverSettings)
		{
			//server = MongoServer.Create("mongodb://" + serverSettings);
			server = MongoServer.Create(serverSettings);
			credentials = new MongoCredentials(serverSettings.Username, serverSettings.Password);
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

		/// <summary>
		/// Gets MongoCollection filled with items from the database collection that are equal to provided class name.
		/// </summary>
		/// <typeparam name="T">Class to bind record to.</typeparam>
		/// <returns>Generic MongoCollection.</returns>
		public static MongoCollection<T> GetCollection<T>()
		{
			var db = ServerConnection.Server.GetDatabase(ServerConnection.DatabaseName, credentials);
			var collection = db.GetCollection<T>((typeof(T).Name));
			try
			{
				collection.Validate();
			}
			catch(Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			return collection;
		}
	}
}
