
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Tools.Connectivity
{
    public class CommonDbContext : IDisposable
    {
        #region Members
        public static CommonDbContext Create() { return new CommonDbContext(); }

        // Note: Static initializers are thread safe.
        public static readonly string DataProvider = ConfigurationManager.AppSettings["DataProvider"];
        private static readonly DbProviderFactory factory = DbProviderFactories.GetFactory(DataProvider);
        private string _connectionString = null;

        #endregion

        #region CTORs

        public CommonDbContext() : this("DefaultConnection")
        {

        }
        public CommonDbContext(string connectionStringName)
        {
            _connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        #endregion

   
        #region Data Update handlers

        /// <summary>
        /// Executes Update statements in the database.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Number of rows affected.</returns>
        public int Update(string sql)
        {
            return Update(sql, null);
        }

        /// <summary>
        /// Executes Update statements in the database using parameters. Generaly for blobs and othr complex types.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"> array of db parameters</param>
        /// <returns></returns>
        public int Update(string sql, IList<DbParameter> parameters)
        {
            using (DbConnection connection = factory.CreateConnection())
            {

                connection.ConnectionString = _connectionString;

                using (DbCommand command = factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;
                    if (parameters != null)
                        for (int i = 0; i < parameters.Count; i++)
                            command.Parameters.Add(parameters[i]);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// Executes Insert statements in the database.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        public int Insert(string sql)
        {
            return Insert(sql, false);
        }
        /// <summary>
        /// Executes Insert statements in the database. Optionally returns new identifier.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <param name="getId">Value indicating whether newly generated identity is returned.</param>
        /// <returns>Newly generated identity value (autonumber value).</returns>
        public int Insert(string sql, bool getId)
        {
            return Insert(sql, getId, null);
        }
        /// <summary>
        /// Executes insert statements in the database using parameters. Generaly for blobs and othr complex types.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"> collection of db parameters</param>
        /// <returns></returns>
        public int Insert(string sql, bool getId, IList<DbParameter> parameters)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = _connectionString;
                using (DbCommand command = factory.CreateCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        if (parameters != null)
                            for (int i = 0; i < parameters.Count; i++)
                                command.Parameters.Add(parameters[i]);

                        connection.Open();
                        int id = -1;
                        command.CommandText = sql;
                        id = command.ExecuteNonQuery();
                        // Check if new identity is needed.
                        if (getId)
                        {
                            sql = GetQueryOfIdentityColumn();
                            command.CommandText = sql;
                            id = int.Parse(command.ExecuteScalar().ToString());
                        }

                        return id;
                    }
                    catch (Exception ex) { throw new Exception("Error at insert statement. /p/n SQL:" + sql, ex); }
                }
            }
        }


        /// <summary>
        /// Executes Delete statements in the database.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Number of rows affected.</returns>
        public int Delete(string sql)
        {
            return Delete(sql, null);
        }
        public int Delete(string sql, IList<DbParameter> parameters)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = _connectionString;

                using (DbCommand command = factory.CreateCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        command.CommandText = sql;
                        if (parameters != null)
                            for (int i = 0; i < parameters.Count; i++)
                                command.Parameters.Add(parameters[i]);

                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                    catch (Exception ex) { throw new Exception("Error at delete statement. /p/n SQL:" + sql, ex); }
                }
            }
        }


        /// <summary>
        /// Executes async update statements in the database.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Number of rows affected.</returns>
        public async Task<int> UpdateAsync(string sql)
        {
            return await UpdateAsync(sql, null);
        }
        /// <summary>
        /// Executes async update statements in the database using parameters. Generaly for blobs and othr complex types.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"> array of db parameters</param>
        /// <returns></returns>
        public async Task<int> UpdateAsync(string sql, IList<DbParameter> parameters)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = _connectionString;

                using (DbCommand command = factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;
                    if (parameters != null)
                        for (int i = 0; i < parameters.Count; i++)
                            command.Parameters.Add(parameters[i]);

                    await connection.OpenAsync().ConfigureAwait(false);
                    return await command.ExecuteNonQueryAsync().ConfigureAwait(false);
                }
            }
        }


        /// <summary>
        /// Executes async insert statements in the database.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        public async Task<int> InsertAsync(string sql)
        {
            return await InsertAsync(sql, false);
        }
        /// <summary>
        /// Executes async insert statements in the database. Optionally returns new identifier.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <param name="getId">Value indicating whether newly generated identity is returned.</param>
        /// <returns>Newly generated identity value (autonumber value).</returns>
        public async Task<int> InsertAsync(string sql, bool getId)
        {
            return await InsertAsync(sql, getId, null);
        }
        /// <summary>
        /// Executes async insert statements in the database using parameters. Generaly for blobs and othr complex types.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"> collection of db parameters</param>
        /// <returns></returns>
        public async Task<int> InsertAsync(string sql, bool getId, IList<DbParameter> parameters)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = _connectionString;
                using (DbCommand command = factory.CreateCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        if (parameters != null)
                            for (int i = 0; i < parameters.Count; i++)
                                command.Parameters.Add(parameters[i]);

                        await connection.OpenAsync().ConfigureAwait(false);
                        int id = -1;
                        command.CommandText = sql;
                        id = await command.ExecuteNonQueryAsync().ConfigureAwait(false);
                        if (getId) // Check if new identity is needed.
                        {
                            sql = GetQueryOfIdentityColumn();
                            command.CommandText = sql;
                            object obj = await command.ExecuteScalarAsync().ConfigureAwait(false);
                            id = int.Parse(obj.ToString());
                        }
                        return id;
                    }
                    catch (Exception ex) { throw new Exception("Error at insert statement. /p/n SQL:" + sql, ex); }
                }
            }
        }


        /// <summary>
        /// Executes async delete statements in the database.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Number of rows affected.</returns>
        public async Task<int> DeleteAsync(string sql)
        {
            return await DeleteAsync(sql, null);
        }
        public async Task<int> DeleteAsync(string sql, IList<DbParameter> parameters)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = _connectionString;

                using (DbCommand command = factory.CreateCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        command.CommandText = sql;
                        if (parameters != null)
                            for (int i = 0; i < parameters.Count; i++)
                                command.Parameters.Add(parameters[i]);

                        connection.Open();
                        return await command.ExecuteNonQueryAsync().ConfigureAwait(false);
                    }
                    catch (Exception ex) { throw new Exception("Error at delete statement. /p/n SQL:" + sql, ex); }
                }
            }
        }

        #endregion

        #region Data Retrieve Handlers

        public DataSet GetDataSet(string sql)
        {
            return GetDataSet(sql, null);
        }

        /// <summary>
        /// Populates a DataSet according to a Sql statement.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Populated DataSet.</returns>
        public DataSet GetDataSet(string sql, IList<DbParameter> parameters)
        {
            try
            {
                using (DbConnection connection = factory.CreateConnection())
                {
                    connection.ConnectionString = _connectionString;

                    using (DbCommand command = factory.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = sql;
                        if (parameters != null && parameters.Count > 0)
                            foreach (DbParameter parameter in parameters)
                                command.Parameters.Add(parameter);
                        using (DbDataAdapter adapter = factory.CreateDataAdapter())
                        {
                            adapter.SelectCommand = command;
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(sql, ex);
            }
        }
        /// <summary>
        /// Populates a DataTable according to a Sql statement.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Populated DataTable.</returns>
        public DataTable GetDataTable(string sql, IList<DbParameter> parameters)
        {
            DataTable table = GetDataSet(sql, parameters).Tables[0];
            if (table == null || table.Rows.Count == 0) return null;
            return table;
        }

        /// <summary>
        /// Async populates a DataTable according to a Sql statement.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Populated DataTable.</returns>
        public async Task<DataTable> GetDataTableAsync(string sql, IList<DbParameter> parameters)
        {
            try
            {
                DataTable dt = null;
                using (DbConnection connection = factory.CreateConnection())
                {
                    connection.ConnectionString = _connectionString;

                    using (DbCommand command = factory.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = sql;
                        if (parameters != null && parameters.Count > 0)
                        {
                            foreach (DbParameter parameter in parameters)
                                command.Parameters.Add(parameter);
                        }

                        await connection.OpenAsync().ConfigureAwait(false);

                        using (DbDataReader reader = await command.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            dt = CreateTableSchema(reader);

                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                var dr = dt.NewRow();
                                for (int i = 0; i < dt.Columns.Count; i++)
                                    dr[i] = reader[i];
                                dt.Rows.Add(dr);
                            }
                        }
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(sql, ex);
            }
        }

        /// <summary>
        /// Populates a DataRow according to a Sql statement.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Populated DataRow.</returns>
        public DataRow GetDataRow(string sql, IList<DbParameter> parameters)
        {
            DataRow row = null;
            DataTable dt = GetDataTable(sql, parameters);
            if (dt == null) return null;
            if (dt.Rows.Count > 0)
                row = dt.Rows[0];
            return row;
        }
        /// <summary>
        /// Async populates a DataRow according to a Sql statement.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Populated DataRow.</returns>
        public async Task<DataRow> GetDataRowAsync(string sql, IList<DbParameter> parameters)
        {
            DataTable dt = await GetDataTableAsync(sql, parameters).ConfigureAwait(false);
            if (dt == null || dt.Rows.Count <= 0)
                return null;
            return dt.Rows[0];
        }

        public object GetScalar(string sql)
        {
            return GetScalar(sql, null);
        }
        /// <summary>
        /// Executes a Sql statement and returns a scalar value.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Scalar value.</returns>
        public object GetScalar(string sql, IList<DbParameter> parameters)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = _connectionString;

                using (DbCommand command = factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;
                    if (parameters != null && parameters.Count > 0)
                        foreach (DbParameter parameter in parameters)
                            command.Parameters.Add(parameter);
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception err)
                    {
                        throw new Exception(sql, err);
                    }
                    return command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Execute stored procedure, 
        /// </summary>
        /// <param name="StoredProcedure">Stored procedure name</param>
        /// <param name="columnName">Array of column name</param>
        /// <param name="parameters">List of DBParameters</param>
        /// <returns></returns>
        public DataSet StoredProcedure_GetDataSet(string storedProcedureName, IList<DbParameter> parameters)
        {
            try
            {
                using (DbConnection connection = factory.CreateConnection())
                {
                    connection.ConnectionString = _connectionString;

                    using (DbCommand command = factory.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = storedProcedureName;

                        for (int i = 0; i < parameters.Count; i++)
                            command.Parameters.Add(parameters[i]);

                        using (DbDataAdapter adapter = factory.CreateDataAdapter())
                        {
                            adapter.SelectCommand = command;
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public DataTable StoredProcedure_GetDataTable(string storedProcedureName, IList<DbParameter> parameters)
        {
            return StoredProcedure_GetDataSet(storedProcedureName, parameters).Tables[0];
        }
        public DataRow StoredProcedure_GetDataRow(string storedProcedureName, IList<DbParameter> parameters)
        {
            return StoredProcedure_GetDataTable(storedProcedureName, parameters).Rows[0];
        }
        public void StoredProcedure_Execute(string storedProcedureName, ref IList<DbParameter> parameters)
        {
            try
            {
                using (DbConnection connection = factory.CreateConnection())
                {
                    connection.ConnectionString = _connectionString;

                    using (DbCommand command = factory.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = storedProcedureName;

                        for (int i = 0; i < parameters.Count; i++)
                            command.Parameters.Add(parameters[i]);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public object StoredProcedure_ExecuteScalar(string storedProcedureName, ref IList<DbParameter> parameters)
        {
            return StoredProcedure_GetDataRow(storedProcedureName, parameters)[0];
        }

        #endregion

        #region Utility methods

        /// <summary>
        /// Escapes an input string for database processing, that is, 
        /// surround it with quotes and change any quote in the string to 
        /// two adjacent quotes (i.e. escape it). 
        /// If input string is null or empty a NULL string is returned.
        /// </summary>
        /// <param name="s">Input string.</param>
        /// <returns>Escaped output string.</returns>
        public string Escape(string s)
        {
            return Escape(s, true);
        }
        /// <summary>
        /// Escapes an input string for database processing, that is, 
        /// surround it with quotes and change any quote in the string to 
        /// two adjacent quotes (i.e. escape it). 
        /// If input string is null or empty a NULL string is returned.
        /// <param name="s"></param>
        /// <param name="addApostrophes"></param>
        /// <returns></returns>
        public string Escape(string s, bool addApostrophes)
        {
            if (s.Trim() == "NULL") return "NULL";
            if (String.IsNullOrEmpty(s))
                return "NULL";
            else
            {
                if (addApostrophes)
                    return "'" + s.Trim().Replace("'", "''") + "'";
                else
                    return s.Trim().Replace("'", "''");
            }
        }
        /// <summary>
        /// Escapes an input string for database processing, that is, 
        /// surround it with quotes and change any quote in the string to 
        /// two adjacent quotes (i.e. escape it). 
        /// If input string is null or empty a NULL string is returned.
        /// <param name="s"></param>
        /// <param name="addApostrophes"></param>
        /// <param name="isUnicode"></param>
        /// <returns></returns>
        public string AddUnicode(string s, bool isUnicode)
        {
            if (String.IsNullOrEmpty(s))
                return "NULL";

            return isUnicode ? "N'" + s.Trim().Replace("'", "''") + "'" : "'" + s.Trim().Replace("'", "''") + "'";
        }
        /// <summary>
        /// Escapes an input string for database processing, that is, 
        /// surround it with quotes and change any quote in the string to 
        /// two adjacent quotes (i.e. escape it). 
        /// Also trims string at a given maximum length.
        /// If input string is null or empty a NULL string is returned.
        /// </summary>
        /// <param name="s">Input string.</param>
        /// <param name="maxLength">Maximum length of output string.</param>
        /// <returns>Escaped output string.</returns>
        public string Escape(string s, int maxLength)
        {
            if (String.IsNullOrEmpty(s))
                return "NULL";
            else
            {
                s = s.Trim();
                if (s.Length > maxLength) s = s.Substring(0, maxLength - 1);
                return "'" + s.Trim().Replace("'", "''") + "'";
            }
        }

        /// <summary>
        /// Generate insert query according to the input parameters, 
        /// The parameter should show like this - @parameterName 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public string GenerateInsertQuery(string tableName, IList<DbParameter> parameters)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO ").Append(tableName)
              .Append("( ");

            foreach (var p in parameters)
                sb.Append(p.ParameterName.Remove(0, 1)).Append(", ");

            sb = sb.Remove(sb.Length - 3, 2);
            sb.Append(" )");

            sb.Append(" VALUES( ");
            foreach (var p in parameters)
                sb.Append(p.ParameterName).Append(", ");

            sb = sb.Remove(sb.Length - 2, 2);
            sb.Append(" )");
            
            return sb.ToString();
        }
        /// <summary>
        /// Generate update query according to the input parameters, 
        /// The parameter should show like this - @parameterName 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public string GenerateUpdateQuery(string tableName, IList<DbParameter> parameters)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE ").Append(tableName).Append(" SET ");

            for (int i = 1; i < parameters.Count; i++)
                sb.Append(parameters[i].ParameterName.Remove(0, 1)).Append("=").Append(parameters[i].ParameterName).Append(", ");

            sb = sb.Remove(sb.Length - 2, 2);

            sb.Append(" WHERE ").Append(parameters[0].ParameterName.Remove(0, 1)).Append(" = ").Append(parameters[0].ParameterName);

            return sb.ToString();
        }

        #endregion

        #region Private Helper Methods

        /// <summary>
        /// this methos take sqlQuery and retrieve the table name in this query
        /// </summary>
        /// MTS
        /// <param name="sqlQuery">Sql Query</param>
        /// <returns>Table name</returns>
        private static string GetTableNameFromSqlQuery(string sqlQuery)
        {
            sqlQuery = sqlQuery.ToLower();
            sqlQuery = sqlQuery.Remove(0, sqlQuery.IndexOf("into") + 4).Trim();
            return sqlQuery.Substring(0, sqlQuery.IndexOf(" "));
        }

        private string GetQueryOfIdentityColumn()
        {
            switch (DataProvider)
            {
                // Access
                case "System.Data.OleDb":
                    return "SELECT @@IDENTITY";
                // Sql Server
                case "System.Data.SqlClient":
                    return "SELECT SCOPE_IDENTITY()";
                case "MySql.Data.MySqlClient":
                    return "SELECT LAST_INSERT_ID();";
                default:
                    return "SELECT @@IDENTITY";
            }
        }
        private string buildSqlPlusIdentity(string sql)
        {
            switch (DataProvider)
            {
                // Access
                case "System.Data.OleDb":
                    return sql + "; SELECT @@IDENTITY";
                // Sql Server
                case "System.Data.SqlClient":
                    return sql + "; SELECT SCOPE_IDENTITY()";
                // Oracle
                case "System.Data.OracleClient":
                    return sql;
                default:
                    return sql + "; SELECT @@IDENTITY";
            }
        }
        private static int getIdFromQuery(DbCommand command)
        {
            switch (DataProvider)
            {
                case "System.Data.SqlClient":
                    return int.Parse(command.ExecuteScalar().ToString());
                default:
                    throw new Exception("");
            }
        }

        public void Dispose() { }

        private DataTable CreateTableSchema(DbDataReader reader)
        {
            DataTable schema = reader.GetSchemaTable();
            DataTable dataTable = new DataTable();
            if (schema != null)
            {
                foreach (DataRow dr in schema.Rows)
                {
                    string columnName = System.Convert.ToString(dr["ColumnName"]);
                    DataColumn column = new DataColumn(columnName, (Type)(dr["DataType"]));
                    dataTable.Columns.Add(column);
                }
            }
            return dataTable;
        }

        #endregion
    }
}
