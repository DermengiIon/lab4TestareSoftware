using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Aplicatie_1.Variants
{
    public class _9gagSearch : AbstractTest
    {
        IWebDriver drive = new ChromeDriver();

        [SetUp]
        public override void Initialize()
        {
            drive.Manage().Window.Maximize();
            drive.Url = "https://9gag.com/";
        }
        [Test]
        public override void Search()
        {
            drive.FindElement(By.ClassName("search")).Click();
            drive.FindElement(By.Name("query")).SendKeys("dell xps 15");
            drive.FindElement(By.Name("query")).SendKeys(Keys.Enter);

            if (drive.FindElement(By.ClassName("logo")).Displayed)
            {
                Console.WriteLine("\n***\nThe 9gag header is displayed\n***\n");
            }
            else
            {
                Console.WriteLine("\n***\nThe 9gag header is NOT displayed !!!\n***\n");
            }
        }
        [TearDown]
        public override void EndTest()
        {
            drive.Close();
        }
    }
}
