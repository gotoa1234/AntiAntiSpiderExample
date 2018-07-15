using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1.WebDriverExample
{
    public class NameExample
    {
        public NameExample()
        {
            this.execute();
        }

        /// <summary>
        /// 執行Name的Dom讀取
        /// </summary>
        public void execute()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name/");
            IWebElement element = driver.FindElement(By.Name("myName"));
            if (element.Displayed) { GreenMessage("Yes! I can see the element, it's right there!!!"); } else { RedMessage("Well, something went wrong, I couldn't see the element!"); }
            driver.Quit();
        }

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(message); Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(message); Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
