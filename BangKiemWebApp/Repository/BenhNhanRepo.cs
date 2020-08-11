using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.ViewModels;
using Dapper;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;

namespace BangKiemWebApp.Repository
{
    public class BenhNhanRepo : IBenhNhanRepo
    {
        //private readonly IConfiguration _config;
        private readonly Startup.ConnectionStrings _connectionStrings;

        public BenhNhanRepo(IConfiguration config, IOptions<Startup.ConnectionStrings> connectionStrings)
        {
            //_config = config;
            _connectionStrings = connectionStrings.Value;
        }

        //protected IDbConnection Connection
        //{
        //    get
        //    {
        //        var connectionString = _config.GetSection("ConnectionStrings:Db29").Value;
        //        var conn = new OracleConnection(connectionString);
        //        return conn;
        //    }
        //}
        public async Task<BenhNhanViewModel> GetInfoBn(string maBn)
        {
            var sqlInfoBn =
                $@"select dt.mabn, bn.hobenhnhan || ' ' || bn.chulotbenhnhan || ' ' || bn.tenbenhnhan as HoTenBN
                , bn.namsinh, p.tenphai as Phai , dt.maicd, dt.benhchinh
                from  p_benhandt dt                
                inner join p_dmbenhnhan bn on bn.mabn = dt.mabn
                inner join p_dmphai p on p.idphai = bn.phai
                where bn.mabn = '{maBn}' and dt.mavaovien = (SELECT max(mavaovien) FROM P_BENHANDT where mabn='{maBn}') and dt.noitiepdon != 0
                group by dt.mabn, bn.hobenhnhan || ' ' || bn.chulotbenhnhan || ' ' || bn.tenbenhnhan, bn.namsinh,p.tenphai,
                dt.maicd, dt.benhchinh
                ";

            //Lấy thông tin bệnh nhân vào viện (có số vào viện....../...)
            var sqlEx = $@"select dt.mabn, bn.hobenhnhan || ' ' || bn.chulotbenhnhan || ' ' || bn.tenbenhnhan as HoTenBN
                , bn.namsinh, p.tenphai as Phai , dt.maicd, dt.benhchinh
                from  p_benhandt dt
            inner join p_dmbenhnhan bn on bn.mabn = dt.mabn
            inner join p_dmphai p on p.idphai = bn.phai
            where bn.mabn = '{maBn}' and dt.mavaovien = (SELECT max(mavaovien) FROM P_BENHANDT where mabn = '{maBn}') and instr(dt.sovaovien,'/') > 1
            group by dt.mabn, bn.hobenhnhan || ' ' || bn.chulotbenhnhan || ' ' || bn.tenbenhnhan, bn.namsinh,p.tenphai,
            dt.maicd, dt.benhchinh ";

            var sqlDotDieuTri =
                $@"select dt.mavaovien
                    , dt.maql
                    , kp.tenkhoaphong
                    , to_char(hd.ngay,'dd/MM/yyyy HH:Mi:ss') as ngay
                    from p_hiendien hd
                    inner join p_benhandt dt on dt.maql = hd.maql
                    inner join p_dmkhoaphongbenhvien kp on kp.idkhoaphong = hd.idkhoaphong
                    where dt.mabn = '{maBn}'";

            var arrayBenhNhanViewModel = new BenhNhanViewModel();

            using (var conn = new OracleConnection(_connectionStrings.Db29))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    try
                    {
                        var dotDieuTri = await conn.QueryAsync<DotDieuTri>(sqlDotDieuTri);
                        var infoBn = await conn.QueryAsync<BenhNhanInfo>(sqlInfoBn);
                        arrayBenhNhanViewModel.BnInfo = infoBn.ToList();
                        arrayBenhNhanViewModel.DotDieuTris = dotDieuTri.ToList();
                        arrayBenhNhanViewModel.Success = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        arrayBenhNhanViewModel.BnInfo = null;
                        arrayBenhNhanViewModel.DotDieuTris = null;
                        arrayBenhNhanViewModel.Success = false;
                    }
                    
                    //return arrayBenhNhanViewModel;
                }
            }
            return arrayBenhNhanViewModel;
        }
    }
}
