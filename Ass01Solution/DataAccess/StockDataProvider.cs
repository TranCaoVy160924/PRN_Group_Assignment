using System.Data;
using Microsoft.Data.SqlClient;

namespace Ass1.DataAccess
{
    public class StockDataProvider
    {
        public StockDataProvider() { }
        //---------------------------------------------
        private string ConnectionString { get; set; }
        //---------------------------------------------
        public StockDataProvider(string connectionString)
            => ConnectionString = connectionString;
        //---------------------------------------------
        public void CloseConnection(SqlConnection connection)
            => connection.Close();
        //---------------------------------------------
        public SqlParameter CreateParameter(
            string name, int size, object value, DbType dbType,
            ParameterDirection direction = ParameterDirection.Input)
        {
            SqlParameter parameter = new SqlParameter
            {
                DbType = dbType,
                ParameterName = name,
                Size = size,
                Direction = direction,
                Value = value
            };
            return parameter;
        }
        //---------------------------------------------
        //Execute query
        public IDataReader ExecuteSqlQuery(
            string commandText, CommandType commandType,
            out SqlConnection connection, params SqlParameter[] parameters)
        {
            IDataReader reader = null;
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return reader;
        }
        //---------------------------------------------
        //Excute Update
        public void ExecuteSqlUpdate(string commandText, CommandType commandType,
            params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        ////---------------------------------------------
        //public void Insert(string commandText, CommandType commandType,
        //    params SqlParameter[] parameters)
        //{
        //    try
        //    {
        //        using var connection = new SqlConnection(ConnectionString);
        //        connection.Open();
        //        using var command = new SqlCommand(commandText, connection);
        //        command.CommandType = commandType;
        //        if (parameters != null)
        //        {
        //            foreach (var parameter in parameters)
        //            {
        //                command.Parameters.Add(parameter);
        //            }
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        ////---------------------------------------------
        //public void Update(string commandText, CommandType commandType,
        //    params SqlParameter[] parameters)
        //{
        //    try
        //    {
        //        using var connection = new SqlConnection(ConnectionString);
        //        connection.Open();
        //        using var command = new SqlCommand(commandText, connection);
        //        command.CommandType = commandType;
        //        if (parameters != null)
        //        {
        //            foreach (var parameter in parameters)
        //            {
        //                command.Parameters.Add(parameter);
        //            }
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
    }
}
