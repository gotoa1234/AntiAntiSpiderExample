using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.WebDriverExample
{
    public class CheckBox
    {
        /// <summary>
        /// 
        /// </summary>
        public CheckBox()
        {
            this.Execute();
        }

        public void Execute()
        {
            IWebDriver driver = new ChromeDriver();
            IWebElement element;

            string url = "http://testing.todorvachev.com/special-elements/check-button-test-3/";
            string option = "2";
            driver.Navigate().GoToUrl(url);
            element = driver.FindElement(By.XPath("//*[@id=\"post-33\"]/div/p[7]/input[" + option + "]"));
            //element.SendKeys(Keys.Space); //Thread.Sleep(4000);
            bool isChecked = bool.TryParse(element.GetAttribute("checked"), out isChecked);
            if (isChecked)
            {
                Console.WriteLine("This checkbox is already checked!");
            }
            else
            {
                Console.WriteLine("Huh, someone left the checkbox unchecked, lets check it!"); element.Click();
            }
            driver.Quit();
        }

    }
}
