using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelenimBasicsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [Test]
        public void test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:3030/admin";

            IWebElement loginField = driver.FindElement(By.XPath(".//*[@type='text']"));
            loginField.SendKeys("admin");

            driver.FindElement(By.XPath(".//*[@type='password']")).SendKeys("admin");

            driver.FindElement(By.XPath(".//*[@type='submit']")).Click();

            IWebElement newPostButton = driver.FindElement(By.CssSelector(".panel-container__newPost"));
            Assert.IsTrue(newPostButton.Displayed, "Login is failed");

            Thread.Sleep(3000);
            driver.Close();
        }
    }
}
