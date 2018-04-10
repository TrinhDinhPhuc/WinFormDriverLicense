using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HocVienRepository : IHocVienRepository
    {
        public bool Delete(string MaHV)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                int result = db.Execute("delete from TTHocVien where MaHV=@MaHV", new { MaHV = MaHV }, commandType: CommandType.Text);
                return result != 0;
            }
        }

        public List<HocVien> GetAll()
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<DTO.HocVien>("select * from TTHocVien", commandType: CommandType.Text).ToList();
                
            }
        }
        public string Insert(HocVien obj)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters p = new DynamicParameters();
                //p.Add("@MaHV", dbType: DbType.String, direction:ParameterDirection.Output,size:20);
                p.AddDynamicParams(new { MaHV ="", TenHV= obj.TenHV , HoHV = obj.HoHV , NgaySinh = obj.NgaySinh , SoCMND = obj.SoCMND , NgayCapCMND=obj.NgayCapCMND, SDT = obj.SDT , DiaChi =obj.DiaChi , DiemTH = obj.DiemTH , NgayDK = "", KyThi = ""});
                db.Execute("sp_HocVien_Insert", p, commandType: CommandType.StoredProcedure);
                return p.Get<string>("@MaHV");
            }
        }

        public bool Update(HocVien obj)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            { 
                if (db.State == ConnectionState.Closed)
                    db.Open();
                    int result =db.Execute("sp_HocVien_Update", new { MaHV= obj.MaHV, TenHV = obj.TenHV, HoHV = obj.HoHV, NgaySinh = obj.NgaySinh, SoCMND = obj.SoCMND, NgayCapCMND = obj.NgayCapCMND, SDT = obj.SDT, DiaChi = obj.DiaChi, DiemTH = obj.DiemTH }, commandType: CommandType.StoredProcedure);
                return result != 0;
            }
            
        }
    }
}
