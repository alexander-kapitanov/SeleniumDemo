using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced
{
    class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = ".//*[@type='text']")]
        private IWebElement loginField;

        [FindsBy(How = How.XPath, Using = ".//*[@type='password']")]
        private IWebElement passwordField;

        [FindsBy(How = How.XPath, Using = ".//*[@type='submit']")]
        private IWebElement loginButton;

        public LoginPage SetLogin(String login)
        {
            loginField.SendKeys(login);
            return this;
        }

        public LoginPage SetPassword(String password)
        {
            passwordField.SendKeys(password);
            return this;

        }

        public LoginPage Login()
        {
            new Actions(driver).Click(loginButton).Build().Perform();
            return this;
        }

        public void Login(String login, String password)
        {
            SetLogin(login).SetPassword(password).Login();
        }

        public Boolean isLoginPerformedSuccessfully()
        {
            try
            {
                return !loginButton.Displayed;
            } catch (Exception e)
            {
                return true;
            }
        }

    }
}
