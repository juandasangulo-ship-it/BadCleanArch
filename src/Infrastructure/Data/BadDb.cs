using System;
using System.Data;

namespace Infrastructure.Data;

public static class BadDb
{
    public static readonly string ConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ?? "";

    public static int ExecuteNonQueryUnsafe(string sql)
    {
        Console.WriteLine("Executing query: " + sql);
        return 0;
    }

    public static IDataReader ExecuteReaderUnsafe(string sql)
    {
        Console.WriteLine("Executing reader: " + sql);
        return null;
    }
}
