using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.WebDriverExample
{
    public class ClassNameSelector
    {
        /// <summary>
        /// 取得 Dom 的Class
        /// </summary>
        public ClassNameSelector()
        {
            this.Execute();
        }


        public void Execute()
        {
            string url = "http://testing.todorvachev.com/selectors/class-name/"; string className = "testClass";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.ClassName(className));
            Console.WriteLine(element.Text);
            driver.Quit();
        }

        private static void RedMessage(string message) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(message); Console.ForegroundColor = ConsoleColor.White; }
        private static void GreenMessage(string message) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(message); Console.ForegroundColor = ConsoleColor.White; }
    }
}
