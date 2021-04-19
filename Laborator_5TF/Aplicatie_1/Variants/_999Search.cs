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
    public class _999Search : AbstractTest
    {
        IWebDriver drive = new ChromeDriver();

        [SetUp]
        public override void Initialize()
        {
            drive.Manage().Window.Maximize();
            drive.Url = "https://999.md/ru/";
        }
        [Test]
        public override void Search()
        {
            drive.FindElement(By.Name("query")).SendKeys("dell xps 15");
            drive.FindElement(By.ClassName("header__search__button")).Submit();

            if (drive.FindElement(By.ClassName("header_bar_logo")).Displayed)
            {
                Console.WriteLine("\n***\nThe 999 header is displayed\n***\n");
            }
            else
            {
                Console.WriteLine("\n***\nThe 999 header is NOT displayed !!!\n***\n");
            }
        }
        [TearDown]
        public override void EndTest()
        {
            drive.Close();
        }
    }
}
