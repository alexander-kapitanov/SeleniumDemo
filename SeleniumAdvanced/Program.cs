using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [Test]
        public void LoginTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:3030/admin";

            LoginPage loginPage = new LoginPage(driver);
            // loginPage
            //     .SetLogin("admin")
            //    .SetPassword("admin")
            //    .Login();
            loginPage.Login("admin", "admin");

            Assert.IsTrue(loginPage.isLoginPerformedSuccessfully(), "Login failed");
        }
    }
}
