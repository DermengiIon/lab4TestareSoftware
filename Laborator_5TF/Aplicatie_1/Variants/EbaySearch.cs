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
    public class EbaySearch : AbstractTest
    {
        IWebDriver drive = new ChromeDriver();

        [SetUp]
        public override void Initialize()
        {
            drive.Manage().Window.Maximize();
            drive.Url = "https://www.ebay.com/";
        }
        [Test]
        public override void Search()
        {
            drive.FindElement(By.Name("_nkw")).SendKeys("dell xps 15");
            drive.FindElement(By.Id("gh-btn")).Submit();

            if (drive.FindElement(By.Id("gh-logo")).Displayed)
            {
                Console.WriteLine("\n***\nThe Ebay header is displayed\n***\n");
            }
            else
            {
                Console.WriteLine("\n***\nThe Ebay header is NOT displayed !!!\n***\n");
            }
        }
        [TearDown]
        public override void EndTest()
        {
            drive.Close();
        }
    }
}
