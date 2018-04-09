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
    public class NhanVienRepository : INhanVienRepository
    {
        public bool Delete(string TaiKhoan)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                int result = db.Execute("delete from TTNhanVien where TaiKhoan=@TaiKhoan", new { TaiKhoan = TaiKhoan }, commandType: CommandType.Text);
                return result != 0;
            }
        }

        public List<NhanVien> GetAll()
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<DTO.NhanVien>("select * from TTNhanVien", commandType: CommandType.Text).ToList();
                
            }
        }
        public string Insert(NhanVien obj)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters p = new DynamicParameters();
                //p.Add("@TaiKhoan", dbType: DbType.String, direction:ParameterDirection.InputOutput,size:20);
                p.AddDynamicParams(new { TaiKhoan = obj.TaiKhoan, MatKhau = obj.MatKhau, HoNV = obj.HoNV, TenNV = obj.TenNV, DiaChi = obj.DiaChi, SDT = obj.SDT });

                db.Execute("sp_NhanVien_Insert", p, commandType: CommandType.StoredProcedure);
                return p.Get<string>("@TaiKhoan");
            }
        }

        public bool Update(NhanVien obj)
        {
            using (IDbConnection db = new SqlConnection(Helper.ConnectionString))
            { 
                if (db.State == ConnectionState.Closed)
                    db.Open();
                    int result =db.Execute("sp_NhanVien_Update", new { TaiKhoan = obj.TaiKhoan, MatKhau = obj.MatKhau, HoNV = obj.HoNV, TenNV = obj.TenNV, DiaChi = obj.DiaChi, SDT = obj.SDT, TruyCapCuoi = obj.TruyCapCuoi}, commandType: CommandType.StoredProcedure);
                return result != 0;
            }
            
        }
    }
}
