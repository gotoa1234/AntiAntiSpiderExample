using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.WebDriverExample
{
    public class NoSuchElement
    {
        public NoSuchElement()
        {
            this.Execute();

        }

        public void Execute()
        {
            string url = "http://testing.todorvachev.com/selectors/css-path/"; string cssPath = "#post-108 > div > fig img"; string xPath = "//*[@id=\"post-108\"]/div/figure/img";
            OpenQA.Selenium.IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            IWebElement cssPathElement; IWebElement xPathElement = driver.FindElement(By.XPath(xPath));
            try
            {
                cssPathElement = driver.FindElement(By.CssSelector(cssPath));
                if (cssPathElement.Displayed) { GreenMessage("I can see the CSS Path Element!"); }
            }
            catch (NoSuchElementException) { RedMessage("I can't see the CSS Path Element!"); }
            if (xPathElement.Displayed) { GreenMessage("I can see the X Path Element!"); } else { RedMessage("I can't see the CSS Path Element!"); }
            driver.Quit();
        }
        private static void RedMessage(string message) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(message); Console.ForegroundColor = ConsoleColor.White; }
        private static void GreenMessage(string message) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(message); Console.ForegroundColor = ConsoleColor.White; }
    }


    
}
