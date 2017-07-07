using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Npgsql;

namespace FrameApp.DAL
{
    public class PostgreConnectData : IConnectData<NpgsqlConnection>
    {
        public string Server { get; private set; }
        public string Port { get; private set; }
        public string User { get; private set; }
        public string Password { get; private set; }
        public string Database { get; private set; }

        public string ConnectionString { get; private set; }

        public PostgreConnectData(string server, string port, string user, string password, string database)
        {
            Server = server;
            Port = port;
            User = user;
            Password = password;
            Database = database;

            ConnectionString = CreateConnectionString();
        }

        private string CreateConnectionString()
        {
            return $"Server = {Server}; Port = {Port}; User = {User}; Password = {Password}; Database = {Database};";
        }

        public NpgsqlConnection SetConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }
    }
}
