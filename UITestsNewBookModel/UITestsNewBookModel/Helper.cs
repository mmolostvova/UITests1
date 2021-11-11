using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.POM
{
    static public class Helper
    {
        public static string AutoEmailUser()
        {
            DateTime dataTime = new DateTime();
            dataTime = DateTime.Now;
            string name = dataTime.ToString("ddMMyyyyhhmmss") + "@sorrytest.com";
            return name;
        }
    }
}

