using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using BangKiemWebApp.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;

namespace BangKiemWebApp.Repository
{
    public class BangKiemRepo : IBangKiemRepo
    {
        //private readonly IConfiguration _config;
        private readonly ILogger<BangKiemRepo> _logger;
        private readonly Startup.ConnectionStrings _connectionStrings;

        public BangKiemRepo(IConfiguration config, ILogger<BangKiemRepo> logger, ILoggerFactory logFactory, IOptions<Startup.ConnectionStrings> connectionStrings)
        {
            //_config = config;
            _logger = logger;
            _connectionStrings = connectionStrings.Value;
            _logger = logFactory.CreateLogger<BangKiemRepo>();
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

        public async Task<int> Insert(BangKiemDetailViewModel obj)
        {
            int result = 0;

            using (var conn = new OracleConnection(_connectionStrings.Db06))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            var idBn = Helper.GeneralMethods.CreateIdRandom();
                            var userName = Helper.GeneralMethods.GetUsername();
                            //Insert thông tin bệnh nhân
                            var sqlBnInfo = 
                                $@"insert into bangkiem_ttbn
                                    (
                                        id,mabn,HOTENBN,NAMSINH,PHAI,mavaovien,maql
                                        ,MAICD,BENHCHINH,tenkhoaphong,username
                                    )
                                    values
                                    (
                                        {idBn},{obj.MaBn},N'{obj.HoTenBn}',{obj.NamSinh},N'{obj.Phai}',{obj.MaVaoVien},{obj.MaQl}
                                        ,'{obj.MaIcd}',N'{obj.BenhChinh}',N'{obj.TenKhoaPhong}','{userName}')";

                            await conn.ExecuteAsync(sqlBnInfo, obj, tran);

                            foreach (var item in obj.NoiDungs)
                            {
                                var sqlBangKiemCt =
                                    $@"INSERT INTO BANGKIEM_CHITIET
                                    (
                                        IDNOIDUNG,IDTTBN,DIEM,STATUS
                                    )
                                    VALUES
                                    (
                                        {item.IdNoiDung}, {idBn},{item.Diem},{obj.Status}
                                    )";
                                await conn.ExecuteAsync(sqlBangKiemCt, item, tran);
                            }

                            tran.Commit();
                            _logger.LogInformation("Lưu thành công: ID: " + idBn);
                            result = 1;
                        }
                        catch (Exception e)
                        {
                            _logger.LogInformation(e.Message);
                            tran.Rollback();
                            result = 0;
                        }
                    }
                    return result;
                }
            }
            return result;
        }
    }
}
