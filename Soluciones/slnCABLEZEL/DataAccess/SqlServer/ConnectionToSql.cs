using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql()
        {
            //connectionString = "Server=POXS44;DataBase= CABLEZEL; integrated security= true";
            connectionString = "Server=tcp:josuemorales.database.windows.net,1433;Initial Catalog=cablezel;Persist Security Info=False;User ID=josueadmin;Password=0096AzureSQL;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
