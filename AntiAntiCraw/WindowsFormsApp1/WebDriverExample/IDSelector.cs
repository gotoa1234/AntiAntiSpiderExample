using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.WebDriverExample
{
    public class IDSelector
    {
        /// <summary>
        /// 取得Dom Id執行
        /// </summary>
        public IDSelector()
        {
            this.Execute();

        }

        public void Execute()
        {
            string url = "http://testing.todorvachev.com/selectors/id/"; string ID = "testImage";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.Id(ID));
            if (element.Displayed) { GreenMessage("Yes, I can see it!"); } else { RedMessage("Nope, its not there!"); }
            driver.Quit();

        }

        private static void RedMessage(string message) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(message); Console.ForegroundColor = ConsoleColor.White; }
        private static void GreenMessage(string message) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(message); Console.ForegroundColor = ConsoleColor.White; }

    }
}
