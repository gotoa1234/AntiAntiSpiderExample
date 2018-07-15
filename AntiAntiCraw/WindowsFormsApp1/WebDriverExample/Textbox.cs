using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1.WebDriverExample
{
    public class Textbox
    {
       
        /// <summary>
        /// 輸入Text 到指定的Dom name檔案
        /// </summary>
        public Textbox()
        {
            this.Excute();

        }

        public void Excute()
        {
            IWebDriver driver = new ChromeDriver();
            IWebElement textBox;
            string url = "http://testing.todorvachev.com/special-elements/text-input-field/";
            driver.Navigate().GoToUrl(url);
            textBox = driver.FindElement(By.Name("username"));
            textBox.SendKeys("Test text");
            Thread.Sleep(3000);
            Console.WriteLine(textBox.GetAttribute("maxlength"));
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
