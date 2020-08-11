using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.ViewModels;
using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace BangKiemWebApp.Repository
{
    public class BaoCaoRepo : IBaoCaoRepo
    {
        private readonly Startup.ConnectionStrings _connectionStrings;

        public BaoCaoRepo(Startup.ConnectionStrings connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }

        public async Task<IList<string>> GetListKhoaPhong()
        {
            var tenKhoaPhongs = new List<string>();

            try
            {
                var sql = 
                    @$"select tenkhoaphong from bangkiem_ttbn group by tenkhoaphong";
                using (var conn = new OracleConnection(_connectionStrings.Db06))
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    if (conn.State == ConnectionState.Open)
                    {
                        var khoaPhong = await conn.QueryAsync<string>(sql);
                        tenKhoaPhongs = khoaPhong.ToList();
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                tenKhoaPhongs = null;
            }

            return tenKhoaPhongs;
        }

        public async Task<IList<BangKiemInfo>> GetBangKiemByKhoa(string tenKhoaPhong)
        {
            List<BangKiemInfo> bangKiemInfos = new List<BangKiemInfo>();

            try
            {
                var sql = 
                    @$"select ct.idnoidung, ct.idttbn, ct.diem, ct.status
                        , bn.mabn, bn.mavaovien, bn.maql, bn.hotenbn,bn.phai,bn.namsinh,bn.maicd,bn.benhchinh,bn.tenkhoaphong,bn.ngayud
                        ,nd.ten as tennoidung
                        ,dm.ten as tenbangkiem, dm.id as idbangkiem
                        from bangkiem_chitiet ct 
                        inner join bangkiem_ttbn bn on bn.id = ct.idttbn
                        inner join bangkiem_noidung nd on nd.id = ct.idnoidung
                        inner join bangkiem_danhmuc dm on dm.id = nd.iddm
                        where bn.tenkhoaphong = N'{tenKhoaPhong}'
                        ";
                using (var conn = new OracleConnection(_connectionStrings.Db06))
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    if (conn.State == ConnectionState.Open)
                    {
                        var bangKiemInfoResult = await conn.QueryAsync<BangKiemInfo>(sql);
                        bangKiemInfos = bangKiemInfoResult.ToList();
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                bangKiemInfos = null;
            }

            return bangKiemInfos;
        }

        public Task<IList<BangKiemInfo>> GetAllBangKiem()
        {
            throw new NotImplementedException();
        }

        public Task<IList<BangKiemDetailInfo>> GetBangKiemDetailByKhoaByBangKiem(string tenKhoaPhong, decimal idBangKiem)
        {
            throw new NotImplementedException();
        }
    }
}
