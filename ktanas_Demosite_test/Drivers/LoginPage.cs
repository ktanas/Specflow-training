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


namespace ktanas_DemositeTest
{
    public class LoginPage
    {
        private IWebDriver driver;

        IWebElement Elusername => driver.FindElement(By.Name("UserName"));
        IWebElement Elpassword => driver.FindElement(By.Name("Password"));
        IWebElement Ellogin => driver.FindElement(By.Name("Login"));

        public void EnterUserCredentials(string username, string password)
        {
            Elusername.SendKeys(username);
            Elpassword.SendKeys(password);
        }

        public void PressLoginButton()
        {
            Ellogin.Click();
        }

        /*
        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement username { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "Login")]
        public IWebElement login { get; set; }
        */
    }
}
