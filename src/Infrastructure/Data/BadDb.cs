using System;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure.Data;

using System.Data;
using System.Data.SqlClient;

public static class BadDb
{
    public static readonly string ConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ?? "";

    public static int ExecuteNonQueryUnsafe(string sql)
    {
        // var conn = new SqlConnection(ConnectionString);
        //var cmd = new SqlCommand(sql, conn);
        //conn.Open();
        //return cmd.ExecuteNonQuery();
        return 0;
    }

    public static IDataReader ExecuteReaderUnsafe(string sql)
    {
        /* var conn = new SqlConnection(ConnectionString);
         var cmd = new SqlCommand(sql, conn);
         conn.Open();
         return cmd.ExecuteReader();
        */
        return null;
    }
}
