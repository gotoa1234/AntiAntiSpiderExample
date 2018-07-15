using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.WebDriverExample
{
    public class RadioButton
    {
        public RadioButton()
        {
            this.Excute();

        }

        public void Excute()
        {

            IWebDriver driver = new ChromeDriver();
            IWebElement radioButton;
            string url = "http://testing.todorvachev.com/special-elements/radio-button-test/";
            string[] option = { "1", "3", "5" };
            driver.Navigate().GoToUrl(url);
            for (int i = 0; i < option.Length; i++)
            {
                radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child(" + option[i] + ")"));
                if (
                    radioButton.GetAttribute("checked") == "true") { Console.WriteLine("The " + (i + 1) + " radio button is checked!");
                }
                else {
                    Console.WriteLine("This is one of the unchecked radio buttons!");
                }
            }
            driver.Quit();
        }
    }
}
