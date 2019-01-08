using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string websiteName = "ExecuteAutomation";
            string fullWebsiteName = websiteName.AddSiteExtension();

            //string b = "Hello";
            
            //string tmp = StringExtension.add1("hello");
            Console.WriteLine(fullWebsiteName);
            Console.ReadLine();

        }

        
    }
}
