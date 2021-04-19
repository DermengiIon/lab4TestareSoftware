using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using NUnit.Framework;
using Aplicatie_1.Variants;

namespace Aplicatie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Search search = new Search();

            // Varianta 1
             search.Run(new GoogleSearch());

            // Varianta 2
            // search.Run(new YoutubeSearch());

            // Varianta 3
            // search.Run(new AmazonSearch());

            // Varianta 4
            // search.Run(new EbaySearch());

            // Varianta 5
            // search.Run(new AliexpressSearch());

            // Varianta 6
            // search.Run(new _999Search());

            // Varianta 7
            // search.Run(new RedditSearch());

            // Varianta 8
            // search.Run(new _9gagSearch());
        }
    }
}
