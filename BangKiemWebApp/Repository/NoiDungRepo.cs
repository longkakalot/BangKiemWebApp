using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.Helper;
using BangKiemWebApp.Models;
using BangKiemWebApp.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;

namespace BangKiemWebApp.Repository
{
    public class NoiDungRepo : INoiDungRepo
    {
        //private readonly IConfiguration _config;
        private readonly Startup.ConnectionStrings _connectionStrings;

        public NoiDungRepo(IConfiguration config, IOptions<Startup.ConnectionStrings> connectionStrings)
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

        public Task<NoiDung> GetById(decimal id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<NoiDungViewModel>> GetAll()
        {
            List<NoiDungViewModel> obj = null;

            using (var conn = new OracleConnection(_connectionStrings.Db06))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    string query =
                        @"select nd.id, nd.iddm, nd.ten, nd.stt, nd.ngayud, nd.hide as hideNoiDung, nd.username, nd.style
                                , dm.ten as tenbangkiem, dm.hide as hideBangKiem
                                from bangkiem_noidung nd 
                                inner join bangkiem_danhmuc dm on dm.id = nd.iddm";
                    var objResult = await conn.QueryAsync<NoiDungViewModel>(query);
                    obj = objResult.ToList();
                }
            }
            return obj;
        }

        public async Task<IList<NoiDungViewModel>> GetByIddm(decimal iddm)
        {
            List<NoiDungViewModel> obj = null;

            using (var conn = new OracleConnection(_connectionStrings.Db06))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    string query =
                        @$"select nd.id, nd.iddm, nd.ten, nd.stt, nd.ngayud, nd.hide as hideNoiDung, nd.username, nd.style
                                , dm.ten as tenbangkiem, dm.hide as hideBangKiem
                                from bangkiem_noidung nd 
                                inner join bangkiem_danhmuc dm on dm.id = nd.iddm
                                where nd.iddm = {iddm} and nd.hide = 0 order by nd.stt";
                    var objResult = await conn.QueryAsync<NoiDungViewModel>(query);
                    obj = objResult.ToList();
                }
            }
            return obj;
        }

        public async Task<int> Insert(NoiDung objNoiDung)
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
                    var userName = objNoiDung.Username ?? "null";
                    string query =
                        @$"insert into bangkiem_noidung(id,iddm,ten,stt,username) 
                            values({id},{objNoiDung.Iddm},N'{objNoiDung.Ten}',{objNoiDung.Stt},{userName})";
                    obj = await conn.ExecuteAsync(query);
                    //return obj;
                }
            }

            return obj;
        }

        public Task<int> Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(NoiDung objNoiDung)
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
                    if (objNoiDung.Style == 0 || objNoiDung.Style == 1)
                    {
                        var style = objNoiDung.Style == 0 ? 1 : 0;
                        //cập nhật trạng thái
                        var query =
                            @$"update bangkiem_noidung set style = {style} where id = {objNoiDung.Id} ";
                        obj = await conn.ExecuteAsync(query);
                    }

                    else if (objNoiDung.Hide == 0 || objNoiDung.Hide == 1)
                    {
                        var hide = objNoiDung.Hide == 0 ? 1 : 0;
                        //cập nhật trạng thái
                        var query =
                            @$"update bangkiem_noidung set hide = {hide} where id = {objNoiDung.Id} ";
                        obj = await conn.ExecuteAsync(query);
                    }
                    //else if (objNoiDung.Ten is null && objNoiDung.Style.ToString() != "")
                    //{
                    //    var style = objNoiDung.Style == 0 ? 1 : 0;
                    //    //cập nhật trạng thái
                    //    var query =
                    //        @$"update bangkiem_noidung set style = {style} where id = {objNoiDung.Id} ";
                    //    obj = await conn.ExecuteAsync(query);
                    //}
                    else
                    {
                        //var ngayUd = DateTime.Now;
                        var query =
                            @$"update bangkiem_noidung set ten = N'{objNoiDung.Ten}', stt={objNoiDung.Stt}, ngayUd = sysdate where id = {objNoiDung.Id} ";
                        obj = await conn.ExecuteAsync(query);
                    }

                    //return obj;
                }
            }

            return obj;
        }
    }
}
