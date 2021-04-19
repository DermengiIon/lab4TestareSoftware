using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_1.Variants
{
    public class AmazonSearch : AbstractTest
    {
        IWebDriver drive = new ChromeDriver();

        [SetUp]
        public override void Initialize()
        {
            drive.Manage().Window.Maximize();
            drive.Url = "https://www.amazon.com/";
        }
        [Test]
        public override void Search()
        {
            drive.FindElement(By.Name("field-keywords")).SendKeys("dell xps 15");
            drive.FindElement(By.Id("nav-search-submit-button")).Submit();

            if (drive.FindElement(By.Id("nav-logo-sprites")).Displayed)
            {
                Console.WriteLine("\n***\nThe Amazon header is displayed\n***\n");
            }
            else
            {
                Console.WriteLine("\n***\nThe Amazon header is NOT displayed !!!\n***\n");
            }
        }
        [TearDown]
        public override void EndTest()
        {
            drive.Close();
        }

    }
}
