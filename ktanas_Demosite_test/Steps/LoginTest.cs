using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using ktanas_DemositeTest;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ktanas_DemositeTest.Steps
{
    [Binding]
    public sealed class LoginTest
    {
        //static ChromeOptions chromeOptions = new ChromeOptions();
        //static FirefoxOptions firefoxOptions = new FirefoxOptions();

        //FirefoxDriver driver = ktanas_DemositeTest.Drivers.InitializeFirefoxDriver(firefoxOptions);
        //ChromeDriver driver = ktanas_DemositeTest.Drivers.InitializeChromeDriver(chromeOptions);

        //FirefoxDriver driver;
        // ChromeDriver driver;

        IWebDriver driver;
        LoginPage loginPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = ktanas_DemositeTest.Drivers.InitializeDriver();
 
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com");
        }


        [Given(@"Enter user credentials")]
        public void GivenEnterUserCredentials(Table table)
        {

            var userCredentials = table.CreateInstance<UserCredentials>();
            loginPage = new LoginPage();
            //loginPage.EnterUserCredentials(userCredentials.Username,userCredentials.Password);

            driver.FindElement(By.Name("UserName")).SendKeys(userCredentials.Username);
            driver.FindElement(By.Name("Password")).SendKeys(userCredentials.Password);

            //driver.FindElement(By.Name("UserName")).SendKeys("kowalski");
            //driver.FindElement(By.Name("Password")).SendKeys("abc123");
        }

        [Then(@"PressLoginButton")]
        public void GivenPressLoginButton()
        {
            driver.FindElement(By.Name("Login")).Submit();
        }

        [Then(@"FillOutUserForm")]
        public void ThenFillOutUserForm(Table table)
        {
            var userFormData = table.CreateInstance<UserFormData>();

            var titleId = driver.FindElement(By.Id("TitleId"));
            var selectTitleId = new SelectElement(titleId);

            selectTitleId.SelectByText(userFormData.Title);

            driver.FindElement(By.Name("Initial")).SendKeys(userFormData.Initial);
            driver.FindElement(By.Name("FirstName")).SendKeys(userFormData.FirstName);
            driver.FindElement(By.Name("MiddleName")).SendKeys(userFormData.MiddleName);
            driver.FindElement(By.Name(userFormData.Gender)).Click();
            driver.FindElement(By.Name("Save")).Submit();
        }

        [Then(@"CheckIfUserFormIsVisible")]
        public void ThenCheckIfUserFormIsVisible()
        {
            Assert.That()
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

    }
}
