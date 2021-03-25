using System;
using System.Collections.Generic;

namespace Tool.Connection.DB
{
    /// <summary>
    /// Class command to describe a request sql
    /// </summary>
    public class Command
    {
        /// <summary>
        /// Request Sql
        /// </summary>
        internal string Query { get; private set; }
        /// <summary>
        /// If the request is a stored procedure
        /// </summary>
        internal bool IsStoredProcedure { get; private set; }
        /// <summary>
        /// A collection of parameters with key in format string and an object
        /// </summary>
        internal Dictionary<string, object> Parameters { get; private set; }
        /// <summary>
        /// Constructor of Command
        /// </summary>
        /// <param name="query">Request Sql</param>
        /// <param name="isStoredProcedure">If Request is stored procedure</param>
        public Command(string query,bool isStoredProcedure = false)
        {
            Query = query;
            Parameters = new Dictionary<string, object>();
            IsStoredProcedure = isStoredProcedure;
        }
        /// <summary>
        /// Procedure to add parameter in Dictionary<string,object>
        /// </summary>
        /// <param name="parameterName">string parameter</param>
        /// <param name="value">parameter any format</param>
        public void AddParameter(string parameterName,object value)
        {
            Parameters.Add(parameterName, value ?? DBNull.Value);
        }
    }
}
