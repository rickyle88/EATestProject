using EAAutoFrameWork.Config;
using EAAutoFrameWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Base
{
    public abstract class BaseStep : Base
    {
        public virtual void NavigateSite()
        {
            string url = Settings.AUT;
            DriverContext.browser.GoToURL(url);

            LogHelpers.Write("Naviagated to the page !!!");
        }
    }
}
