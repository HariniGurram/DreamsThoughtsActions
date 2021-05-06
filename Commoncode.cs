using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;


namespace AutomationLibraries
{
    
    public static class Commoncode
    {
        public static IWebDriver driver;
        public static void clickbutton(string logicalname)
        {
                ele.Click();
        }

        public static void selectdropdown(string value ,string logicalname)
        {

        }

        public static void entertext(string logicalname)
        {
            ele.sendkeys();
        }

        public static void driversetup()
        {
            string path = Environment.GetEnvironmentVariable("chromepath");
            driver = new ChromeDriver(path);
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/");
            driver.Manage().Window.Maximize();

        }

        public static void openurl()
        {
            try
            {


            }
            catch
            {

            }


        }


        public static void closedriver()
        {
            driver.Close();

        }

    }
}
