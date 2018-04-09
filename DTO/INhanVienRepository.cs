using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public interface INhanVienRepository
    {
        List<NhanVien> GetAll();
        string Insert(NhanVien obj);

        bool Update(NhanVien obj);
        bool Delete(string TaiKhoan);


    }
}
