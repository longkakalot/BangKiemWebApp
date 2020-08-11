using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;

namespace BangKiemWebApp.Repository
{
    public class DapperBaseRepo
    {
        //private readonly ILogger _logger;

        private readonly IConfiguration _config;

        //This class represents a connection to the database.
        //Dapper will automatically open this connection whenever
        //it is used in a query.
        private readonly IDbConnection _conn;

        protected IDbConnection Connection
        {
            get
            {
                var connectionString = _config.GetSection("ConnectionStrings:Db06").Value;
                var conn = new OracleConnection(connectionString);
                return conn;
            }
        }
        public DapperBaseRepo(IDbConnection conn, IConfiguration config)
        {
            //_logger = logger;
            _conn = conn;
            _config = config;
        }

        

        public List<T> Query<T>(string query, object parameters = null)
        {
            try
            {
                return _conn.Query<T>(query, parameters).ToList();
            }
            catch (Exception ex)
            {
                //_logger.LogInformation(ex.Message);
                return new List<T>();
            }
        }

        public T QuerySingle<T>(string query, object parameters = null)
        {
            try
            {
                return _conn.QuerySingle<T>(query, parameters);
            }
            catch (Exception ex)
            {
                //_logger.LogInformation(ex.Message);
                throw;
            }
        }

        public T QueryFirst<T>(string query, object parameters = null)
        {
            try
            {
                return _conn.QueryFirst<T>(query, parameters);
            }
            catch (Exception ex)
            {
                //_logger.LogInformation(ex.Message);
                return default(T);
            }
        }
    }
}
