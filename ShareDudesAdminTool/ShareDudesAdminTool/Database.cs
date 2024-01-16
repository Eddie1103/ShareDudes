using Npgsql;
using System;
using System.Data;

namespace Connection
{
  public class Database : IDisposable
  {
    private NpgsqlConnection _connection;
    private NpgsqlTransaction _transaction;

    public Database()
    {

    }

    private void Init(string schema)
    {
      Execute(_connection, "SET intervalstyle to iso_8601");
      Execute(_connection, "SET LC_MONETARY='C'");
      Execute(_connection, "SET lc_numeric='C'");
      Execute(_connection, "SET lc_time='C'");
      Execute(_connection, "SET search_path to " + schema + ",public");
      Execute(_connection, "SET ssl_renegotiation_limit=0");
    }

    private void Execute(NpgsqlConnection conn, string command)
    {
      var cmd = conn.CreateCommand();
      cmd.CommandText = command;
      cmd.ExecuteNonQuery();
    }

    public static Database Create()
    {
      var db = new Database();
      db.OpenConnection();
      return db;
    }

    public void OpenConnection()
    {
      // Database login
      var host = "194.62.1.218";
      var port = "5432";
      var username = "postgres";
      var databaseName = "sharedudes";
      var password = "bastard";

      var pg = "Server=" + host + ";Port=" + port + ";Database=" + databaseName + ";User Id=" + username + ";Password=" + password + ";";
      _connection = new NpgsqlConnection(pg);
      _connection.Open();

      _transaction = _connection.BeginTransaction();

      //Init(scheme);
    }

    public void Close()
    {
      if (_connection != null && _transaction != null)
      {
        _transaction.Dispose();
        _transaction = null;
        _connection.Close();
        _connection.Dispose();
        _connection = null;
      }
    }

    public void Commit()
    {
      if (_transaction != null)
      {
        _transaction.Commit();
      }
    }

    public void Rollback()
    {
      if (_transaction != null)
      {
        _transaction.Rollback();
      }
    }

    private string ConvertValueToString(object item)
    {
      if (item is bool boolean)
      {
        return boolean ? "true" : "false"; ;
      }
      else if (item is string text)
      {
        return text;
      }
      else if (item is int intNumber)
      {
        return intNumber.ToString("D");
      }
      else if (item is decimal decimalNumber)
      {
        var cache = decimalNumber.ToString("F8");
        return cache.Replace(',', '.');
      }
      else if (item is DateTime date)
      {
        return date.ToString("yyyy-MM-dd HH:mm:ss");
      }
      else if (item is Enum)
      {
        var enumType = item.GetType();
        return Enum.Format(enumType, item, "D");
      }

      throw new InvalidOperationException(item.ToString() + " konnte nicht convertieren");
    }

    private void CheckConnection()
    {
      if (_connection == null)
      {
        throw new InvalidOperationException("Connection ist nicht aufgebaut.");
      }

      if (_connection.State != System.Data.ConnectionState.Open)
      {
        throw new InvalidOperationException("Connection nicht offen: " + _connection.FullState.ToString());
      }
    }

    public int Save(string tableName, int id, string[] columneNames, object[] columneValues)
    {
      if (columneNames.Length != columneValues.Length)
      {
        throw new InvalidOperationException("Ungleich viele Werte übergeben.");
      }

      CheckConnection();

      var stringList = new List<string>();
      foreach (var item in columneValues)
      {
        stringList.Add(ConvertValueToString(item));
      }

      string sqlCommand;

      if (id <= 0)
      {
        var columneNamesString = string.Join(", ", columneNames);
        var columneValuesString = "'" + string.Join("', '", stringList) + "'";
        sqlCommand = "INSERT INTO " + tableName + "(" + columneNamesString + ") VALUES (" + columneValuesString + ")";
      }
      else
      {
        string[] result = new string[columneNames.Length];
        for (int i = 0; i < columneNames.Length; i++)
        {
          result[i] = columneNames[i] + "='" + stringList[i] + "'";
        }

        var setColumne = string.Join(", ", result);
        sqlCommand = "UPDATE " + tableName + " SET " + setColumne + " WHERE id=" + id.ToString();
      }

      using (var cmd = new NpgsqlCommand(sqlCommand + " RETURNING id;", _connection, _transaction))
      {
        return (int)cmd.ExecuteScalar();
      }
    }

    public NpgsqlDataReader Load(string command)
    {
      CheckConnection();
      using (var cmd = new NpgsqlCommand(command, _connection))
      {
        return cmd.ExecuteReader();
      }
    }

    public int Delete(string tableName, int id)
    {
      CheckConnection();
      using (var cmd = new NpgsqlCommand("delete from " + tableName + " where id=" + id.ToString() + ";", _connection))
      {
        return cmd.ExecuteNonQuery();
      }
    }

    public static bool GetBoolValue(NpgsqlDataReader reader, string columnName)
    {
      return (bool)reader[columnName];
    }

    public static string GetStringValue(NpgsqlDataReader reader, string columnName)
    {
      return reader[columnName].ToString();
    }

    public static int GetIntValue(NpgsqlDataReader reader, string columnName)
    {
      var value = reader[columnName];
      if (reader[columnName] is System.DBNull)
      {
        return int.MinValue;
      }
      else
      {
        return (int)value;
      }
    }

    public static double GetDoubleValue(NpgsqlDataReader reader, string columnName)
    {
      var result = (double)((decimal)reader[columnName]);
      return result;
    }

    public static decimal GetDecimalValue(NpgsqlDataReader reader, string columnName)
    {
      var result = (decimal)reader[columnName];
      return result;
    }

    public static DateTime GetDateTimeValue(NpgsqlDataReader reader, string columnName)
    {
      return (DateTime)reader[columnName];
    }


    public void Dispose()
    {
      Close();
    }
  }
}
