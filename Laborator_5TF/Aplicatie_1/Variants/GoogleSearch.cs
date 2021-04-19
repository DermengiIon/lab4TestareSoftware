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
    public class GoogleSearch: AbstractTest
    {
        IWebDriver drive = new ChromeDriver();

        [SetUp]
        public override void Initialize()
        {
            drive.Manage().Window.Maximize();
            drive.Url = "https://www.google.com/";
        }
        [Test]
        public override void Search()
        {
            drive.FindElement(By.Name("q")).SendKeys("dell xps 15");
            drive.FindElement(By.Name("btnK")).Submit();

            if(drive.FindElement(By.Id("logo")).Displayed)
            {
                Console.WriteLine("\n***\nThe Google header is displayed\n***\n");
            }
            else
            {
                Console.WriteLine("\n***\nThe Google header is NOT displayed !!!\n***\n");
            }
        }
        [TearDown]
        public override void EndTest()
        { 
            drive.Close();
        }
    }
}
