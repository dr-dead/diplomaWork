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
        private static MongoServer server;

        private static bool connected = false;

        private static string databaseName = "";

        public ServerConnection(MongoServer ServerToInstance)
        {
            server = ServerToInstance;
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
    }
}
