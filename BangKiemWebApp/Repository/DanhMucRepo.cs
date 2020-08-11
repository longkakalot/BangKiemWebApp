using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.Helper;
using BangKiemWebApp.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;

namespace BangKiemWebApp.Repository
{
    public class DanhMucRepo : IDanhMucRepo
    {
        //private readonly IConfiguration _config;
        private readonly Startup.ConnectionStrings _connectionStrings;
        public DanhMucRepo(IConfiguration config, IOptions<Startup.ConnectionStrings> connectionStrings)
        {
            //_config = config;
            _connectionStrings = connectionStrings.Value;
        }

        //protected IDbConnection Connection
        //{
        //    get
        //    {
        //        var connectionString = _config.GetSection("ConnectionStrings:Db06").Value;
        //        var conn = new OracleConnection(connectionString);
        //        return conn;
        //    }
        //}

        public Task<int> Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<DanhMuc>> GetAll()
        {
            List<DanhMuc> obj = null;

            using (var conn = new OracleConnection(_connectionStrings.Db06))
            {
                
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    string query =
                        @"select id, ten, hide, ngayud from bangkiem_danhmuc";
                    var objResult = await conn.QueryAsync<DanhMuc>(query);
                    obj = objResult.ToList();
                }
            }
            return obj;
        }

        public async Task<DanhMuc> GetById(decimal id)
        {
            DanhMuc obj = null;

            using (var conn = new OracleConnection(_connectionStrings.Db06))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    string query =
                        @$"select id, ten, hide, ngayud from bangkiem_danhmuc where id = {id}";
                    obj = await conn.QuerySingleOrDefaultAsync<DanhMuc>(query);
                    //return obj;
                }
            }

            return obj;
        }

        //public string CreateIdRandom()
        //{
        //    var rd = new Random();
        //    var id = DateTime.Now.ToString("yyMMddHHmmssfffff") + rd.Next(99999999);
        //    return id;
        //}

        public async Task<int> Insert(DanhMuc objDanhMuc)
        {
            var obj = 0;

            using (var conn = new OracleConnection(_connectionStrings.Db06))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    var id = GeneralMethods.CreateIdRandom();
                    string query =
                        @$"insert into bangkiem_danhmuc(id,ten) values({id},N'{objDanhMuc.Ten}')";
                    obj = await conn.ExecuteAsync(query);
                    //return obj;
                }
            }

            return obj;
        }

        public async Task<int> Update(DanhMuc objDanhMuc)
        {
            var obj = 0;

            using (var conn = new OracleConnection(_connectionStrings.Db06))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    if (objDanhMuc.Ten is null && objDanhMuc.Hide.ToString() != "")
                    {
                        var hide = objDanhMuc.Hide == 0 ? 1 : 0;
                        //cập nhật trạng thái
                        var query =
                            @$"update bangkiem_danhmuc set hide = {hide} where id = {objDanhMuc.Id} ";
                        obj = await conn.ExecuteAsync(query);
                    }
                    else
                    {
                        //var ngayUd = DateTime.Now;
                        var query =
                            @$"update bangkiem_danhmuc set ten = N'{objDanhMuc.Ten}', ngayUd = sysdate where id = {objDanhMuc.Id} ";
                        obj = await conn.ExecuteAsync(query);
                    }

                    //return obj;
                }
            }

            return obj;
        }
    }
}
