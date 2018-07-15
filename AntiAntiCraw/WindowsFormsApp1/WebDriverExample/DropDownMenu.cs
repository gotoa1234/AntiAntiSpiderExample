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
   public  class DropDownMenu
    {
        public DropDownMenu()
        {
           this.Excute();
        }

        public void Excute()
        {
            IWebDriver driver = new ChromeDriver();
            IWebElement dropDownMenu;
            IWebElement elementFromTheDropDownMenu;

            string url = "http://testing.todorvachev.com/special-elements/drop-down-menu-test/";
            string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";
            driver.Navigate().GoToUrl(url);
            dropDownMenu = driver.FindElement(By.Name("DropDownTest"));
            Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));
            elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
            Console.WriteLine("The third option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));
            elementFromTheDropDownMenu.Click();
            Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value")); Thread.Sleep(3000);
            for (int i = 1; i <= 4; i++)
            {
                dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")"; elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
                Console.WriteLine("The " + i + " option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));
            }
            Thread.Sleep(15000);
            driver.Quit();
        }
    }
}
