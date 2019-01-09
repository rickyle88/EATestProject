using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.ConfigElement
{
    //using System.Configuration => ConfigurationElementCollection
    public class EAFrameworkElementCollection : ConfigurationElementCollection

    {
        protected override ConfigurationElement CreateNewElement()
        {
            throw new NotImplementedException();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            throw new NotImplementedException();
        }
    }
}
