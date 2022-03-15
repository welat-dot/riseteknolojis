using Autofac;
using UserDataAccess;

namespace UserBusiness.DepencyResolver
{
    public  class AutofacDepencyModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IletisimDal>().As<IIletisimDal>();
            builder.RegisterType<KisiDal>().As<IKisiDal>();
            builder.RegisterType<IletisimManeger>().As<IIletisimManeger>();
            builder.RegisterType<KisiManager>().As<IKisiManager>();
        }
    }
}
