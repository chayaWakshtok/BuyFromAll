using BL;
using DAL.MySqlManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using Unity.Injection;
using static Entities.DataManagers.IDataManager;

namespace BuyFromAllService.App_Start
{
    public class DiConfig
    {
        public static void RegisterTypes()
        {
            DIManager.Container.RegisterType<IUserManager, MySqlUsersManager>();
            DIManager.Container.RegisterType<User>(
                new InjectionConstructor()
                );
        }
    }
}