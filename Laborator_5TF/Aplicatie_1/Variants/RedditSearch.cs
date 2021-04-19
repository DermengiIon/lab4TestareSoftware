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
    public class RedditSearch : AbstractTest
    {
        IWebDriver drive;

        [SetUp]
        public override void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");
            drive = new ChromeDriver(options);

            drive.Manage().Window.Maximize();
            drive.Url = "https://www.reddit.com/";
        }
        [Test]
        public override void Search()
        {
            drive.FindElement(By.Name("q")).SendKeys("dell xps 15");
            drive.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            if (drive.FindElement(By.ClassName("_1O4jTk-dZ-VIxsCuYB6OR8")).Displayed)
            {
                Console.WriteLine("\n***\nThe Reddit header is displayed\n***\n");
            }
            else
            {
                Console.WriteLine("\n***\nThe Reddit header is NOT displayed !!!\n***\n");
            }
        }
        [TearDown]
        public override void EndTest()
        {
            drive.Close();
        }
    }
}
