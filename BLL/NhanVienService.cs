using Autofac;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienService
    {
        static IContainer _container;
        static NhanVienService()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<NhanVienRepository>().As<INhanVienRepository>();
            _container = builder.Build();

        }
        public static bool Delete (string nhanvienId)
        {
            return _container.Resolve<INhanVienRepository>().Delete(nhanvienId);
        }
        public static List<NhanVien> GetAll()
        {
            return _container.Resolve<INhanVienRepository>().GetAll();
        }
        public static NhanVien Save(NhanVien obj, EntityState state)
        {
            if (state == EntityState.Added)
                obj.TaiKhoan = _container.Resolve<INhanVienRepository>().Insert(obj);
            else
                _container.Resolve<INhanVienRepository>().Update(obj);
            return obj;

        }
    }
}
