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
    class AliexpressSearch : AbstractTest
    {
        IWebDriver drive = new ChromeDriver();

        [SetUp]
        public override void Initialize()
        {
            drive.Manage().Window.Maximize();
            drive.Url = "https://www.aliexpress.com/";
        }
        [Test]
        public override void Search()
        {
            drive.FindElement(By.Name("SearchText")).SendKeys("dell xps 15");
            drive.FindElement(By.ClassName("search-button")).Submit();

            if (drive.FindElement(By.ClassName("logo-base")).Displayed)
            {
                Console.WriteLine("\n***\nThe Aliexpress header is displayed\n***\n");
            }
            else
            {
                Console.WriteLine("\n***\nThe Aliexpress header is NOT displayed !!!\n***\n");
            }
        }
        [TearDown]
        public override void EndTest()
        {
            drive.Close();
        }
    }
}
