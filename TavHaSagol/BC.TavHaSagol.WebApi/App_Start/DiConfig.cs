using AM.Utils;
using AM.Utils.Loggers;
using AM.Utils.PhoneConfirmation;
using BC.TavHaSagol.BO;
using BL;
using DAL.MySqlManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using Unity.Injection;
using static Entities.DataManagers.IDataManager;

namespace BC.TavHaSagol.WebApi.App_Start
{
    public class DiConfig
    {
        public static void RegisterTypes()
        {
            DIManager.Container.RegisterType<IBaseLogger, NLogLogger>();
            DIManager.Container.RegisterType<ICategoryManager, MySqlCategoryManager>();
            DIManager.Container.RegisterType<IBrandManager, MySqlBrandManager>();
            DIManager.Container.RegisterType<Category>(
                         new InjectionConstructor(DIManager.Container.Resolve<ICategoryManager>()));
            DIManager.Container.RegisterType<Brand>(
                 new InjectionConstructor(DIManager.Container.Resolve<IBrandManager>()));

        }
    }
}