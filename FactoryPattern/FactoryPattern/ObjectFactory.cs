using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class ObjectFactory
    {
        public static IBusinessThingy Create()
        {
            var someSetting = Convert.ToBoolean(ConfigurationManager.AppSettings["lolo"]);

            if(someSetting)
            {
                return new ConcreteBusinessObject("lolo");

            }
            else
            {
                return new SecondContreteBusinessObject();
            }
        }
    }
}
