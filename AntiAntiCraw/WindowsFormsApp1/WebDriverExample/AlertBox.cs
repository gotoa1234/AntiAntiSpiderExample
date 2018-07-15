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
    public class AlertBox
    {

        public AlertBox()
        {
            this.Execute();

        }

        public void Execute()
        {
            IWebDriver driver = new ChromeDriver();
            IAlert alert;
            IWebElement image;

            string url = "http://testing.todorvachev.com/special-elements/alert-box/";
            driver.Navigate().GoToUrl(url);
            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Accept();
            image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
            try { if (image.Displayed) { Console.WriteLine("The alert was successfuly accepted and I can see the image!"); } } catch (NoSuchElementException) { Console.WriteLine("Something went wrong!!"); }
            Thread.Sleep(3000);
            driver.Quit();

        }
    }
}
