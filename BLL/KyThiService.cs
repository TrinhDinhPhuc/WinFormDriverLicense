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
    public class KyThiService
    {
        static IContainer _container;
        static KyThiService()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<KyThiRepository>().As<IKyThiRepository>();
            _container = builder.Build();

        }
        public static bool Delete(string KyThi)
        {
            return _container.Resolve<IKyThiRepository>().Delete(KyThi);
        }
        public static List<TTKyThi> GetAll()
        {
            return _container.Resolve<IKyThiRepository>().GetAll();
        }
        public static TTKyThi Save(TTKyThi obj, EntityState state)
        {
            if (state == EntityState.Added)
                obj.KyThi = _container.Resolve<IKyThiRepository>().Insert(obj);
            else
                _container.Resolve<IKyThiRepository>().Update(obj);
            return obj;

        }
    }
}
