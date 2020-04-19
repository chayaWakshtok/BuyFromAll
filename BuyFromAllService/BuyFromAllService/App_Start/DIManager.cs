using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace BuyFromAllService.App_Start
{
    public class DIManager
    {
        static readonly UnityContainer _container = new UnityContainer();
        public static UnityContainer Container
        {
            get
            {
                return _container;
            }
        }
    }
}