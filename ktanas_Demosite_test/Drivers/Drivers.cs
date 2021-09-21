using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ktanas_DemositeTest
{
    public static class Drivers
    {
        public static IWebDriver InitializeDriver()
        {
            //firefoxOptions.AddAdditionalCapability("acceptSslCerts", "true", true);
            //firefoxOptions.AcceptInsecureCertificates = true;

            IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }
 
        public static void RemoveDriver(IWebDriver driver)
        {
            driver.Quit();
            driver.Dispose();
        }
 
    }
}
