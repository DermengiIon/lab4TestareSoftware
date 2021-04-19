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
    public class YoutubeSearch: AbstractTest
    {
        IWebDriver drive = new ChromeDriver();

        [SetUp]
        public override void Initialize()
        {
            drive.Manage().Window.Maximize();
            drive.Url = "https://www.youtube.com/";
        }
        [Test]
        public override void Search()
        {
            drive.FindElement(By.Name("search_query")).SendKeys("dell xps 15");
            drive.FindElement(By.Id("search-icon-legacy")).Submit();

            if (drive.FindElement(By.Id("logo-icon")).Displayed)
            {
                Console.WriteLine("\n***\nThe Youtube header is displayed\n***\n");
            }
            else
            {
                Console.WriteLine("\n***\nThe Youtube header is NOT displayed !!!\n***\n");
            }
        }
        [TearDown]
        public override void EndTest()
        {
            drive.Close();
        }
    }
}
