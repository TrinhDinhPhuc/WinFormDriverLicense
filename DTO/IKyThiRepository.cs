using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public interface IKyThiRepository
    {
        List<TTKyThi> GetAll();
        string Insert(TTKyThi obj);
        bool Update(TTKyThi obj);
        bool Delete(string KyThi);

    }
}
