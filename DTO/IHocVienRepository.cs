using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public interface IHocVienRepository
    {
        List<HocVien> GetAll();
        string Insert(HocVien obj);

        bool Update(HocVien obj);
        bool Delete(string MaHV);


    }
}
