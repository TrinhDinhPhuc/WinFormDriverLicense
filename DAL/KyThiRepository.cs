using Dapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KyThiRepository : IKyThiRepository
    {
        public bool Delete(string KyThi)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                int result = db.Execute("delete from TTKyThi where KyThi= @KyThi", new { KyThi = KyThi }, commandType: CommandType.Text);
                return result != 0;
            }
        }

        public List<TTKyThi> GetAll()
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<DTO.TTKyThi>("select * from TTKyThi", commandType: CommandType.Text).ToList();
                
            }
        }
        public string Insert(TTKyThi obj)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters p = new DynamicParameters();
                p.AddDynamicParams(new { KyThi = obj.KyThi, NgayBatDauDK = obj.NgayBatDauDK , TaiKhoan = obj.TaiKhoan });

                db.Execute("sp_KyThi_Insert", p, commandType: CommandType.StoredProcedure);
                return p.Get<string>("@KyThi");
            }
        }

        public bool Update(TTKyThi obj)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            { 
                if (db.State == ConnectionState.Closed)
                    db.Open();
                    int result =db.Execute("sp_KyThi_Update", new { KyThi = obj.KyThi, NgayBatDauDK = obj.NgayBatDauDK , TaiKhoan = obj.TaiKhoan }, commandType: CommandType.StoredProcedure);
                return result != 0;
            }
            
        }
    }
}
