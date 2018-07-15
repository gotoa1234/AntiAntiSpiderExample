using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.WebDriverExample
{
    public class CSSandXPath
    {
        /// <summary>
        /// 取得Dom 中的Xpath + Css
        /// </summary>
        public CSSandXPath()
        {
            this.Execute();
        }

        public void Execute()
        {
            string url = "http://testing.todorvachev.com/selectors/css-path/"; string cssPath = "#post-108 > div > figure > img"; string xPath = "//*[@id=\"post-108\"]/div/figure/img";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath)); IWebElement xPathElement = driver.FindElement(By.XPath(xPath));
            if (cssPathElement.Displayed) { GreenMessage("I can see the CSS Path Element!"); } else { RedMessage("I can't see the CSS Path Element!"); }
            if (xPathElement.Displayed) { GreenMessage("I can see the X Path Element!"); } else { RedMessage("I can't see the CSS Path Element!"); }
            driver.Quit();
        }

        private static void RedMessage(string message) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(message); Console.ForegroundColor = ConsoleColor.White; }
        private static void GreenMessage(string message) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(message); Console.ForegroundColor = ConsoleColor.White; }

    }


    
}
