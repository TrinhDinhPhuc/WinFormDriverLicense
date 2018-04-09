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
    public class HocVienService
    {
        static IContainer _container;
        static HocVienService()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<HocVienRepository>().As<IHocVienRepository>();
            _container = builder.Build();

        }
        public static bool Delete (string MaHV)
        {
            return _container.Resolve<IHocVienRepository>().Delete(MaHV);
        }
        public static List<HocVien> GetAll()
        {
            return _container.Resolve<IHocVienRepository>().GetAll();
        }
        public static HocVien Save(HocVien obj, EntityState state)
        {
            if (state == EntityState.Added)
                obj.MaHV = _container.Resolve<IHocVienRepository>().Insert(obj);
            else
                _container.Resolve<IHocVienRepository>().Update(obj);
            return obj;

        }
    }
}
