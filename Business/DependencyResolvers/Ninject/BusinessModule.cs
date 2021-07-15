using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IStiService>().To<StiManager>().InSingletonScope();
            Bind<IStiDal>().To<EfStiDal>().InSingletonScope();
            
            Bind<IStkService>().To<StkManager>().InSingletonScope();
            Bind<IStkDal>().To<EfStkDal>().InSingletonScope();

        }
    }
}
