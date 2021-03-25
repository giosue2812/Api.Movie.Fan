using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.Connection.DB
{
    /// <summary>
    /// Class connectio to describe how connection is made
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// Private property for connection database on readonly
        /// </summary>
        private readonly string ConnectionString;
        /// <summary>
        /// Private property to get wich database must use
        /// </summary>
        private readonly DbProviderFactory Factory;
        /// <summary>
        /// Constructor for class connection.
        /// In this Constructor we open a connection for test.
        /// </summary>
        /// <param name="factory">Database used</param>
        /// <param name="connectionString">Connection to database</param>
        public Connection(DbProviderFactory factory, string connectionString)
        {
            Factory = factory;
            ConnectionString = connectionString;
            using(DbConnection connection = GetConnection())
            {
                connection.Open();
            }
        }
        /// <summary>
        /// Function to Execute a non query
        /// </summary>
        /// <param name="command">Command</param>
        /// <returns>int of row affected</returns>
        public int ExecuteNonQuery(Command command)
        {
            using(DbConnection connection = GetConnection())
            {
                using (DbCommand SqlCommand = CreateCommand(connection, command))
                {
                    connection.Open();
                    return SqlCommand.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Function to Execute a request to get one record
        /// </summary>
        /// <param name="command">Command</param>
        /// <returns>object</returns>
        public object ExecuteScalar(Command command)
        {
            using(DbConnection connection = GetConnection())
            {
                using (DbCommand SqlCommand = CreateCommand(connection,command))
                {
                    connection.Open();
                    return SqlCommand.ExecuteScalar();
                }
            }
        }
        /// <summary>
        /// Function Execute a request to get a collection
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="command">Command</param>
        /// <param name="selector">Func<IDataRecord,TResult></param>
        /// <returns>IEnumerable<TResult></returns>
        public IEnumerable<TResult> ExecuteReader<TResult>(Command command,Func<IDataRecord,TResult> selector)
        {
            using(DbConnection connection = GetConnection())
            {
                using(DbCommand SqlCommand = CreateCommand(connection,command))
                {
                    connection.Open();
                    using(IDataReader dataReader = SqlCommand.ExecuteReader())
                    {
                        while(dataReader.Read())
                        {
                            yield return selector(dataReader);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Function to create a request sql. If stored procedure or not.And collect parameter if exist.
        /// </summary>
        /// <param name="connection">DbConnection</param>
        /// <param name="command">Command</param>
        /// <returns>DbCommand</returns>
        private DbCommand CreateCommand(DbConnection connection, Command command)
        {
            DbCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = command.Query;

            if(command.IsStoredProcedure)
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
            }
            foreach(KeyValuePair<string,object> kvp in command.Parameters)
            {
                DbParameter sqlParameter = Factory.CreateParameter();
                sqlParameter.ParameterName = kvp.Key;
                sqlParameter.Value = kvp.Value;

                sqlCommand.Parameters.Add(sqlParameter);
            }
            return sqlCommand;
        }
        /// <summary>
        /// Private Function to connect a database
        /// </summary>
        /// <returns>DbConnection</returns>
        private DbConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString;
            return connection;
        }
    }
}
