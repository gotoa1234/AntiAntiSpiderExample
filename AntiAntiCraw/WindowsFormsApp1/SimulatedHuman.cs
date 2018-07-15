using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 模擬人為 
    /// - 需執行查詢後，取得Ajax 渲染的Html文檔
    /// </summary>
    public class SimulatedHuman
    {
        /// <summary>
        /// Url :  集保戶股權分散表
        /// </summary>
        private readonly string url = "https://www.tdcc.com.tw/smWeb/QryStock.jsp";

        public SimulatedHuman()
        {
        }

        /// <summary>
        /// 取得集保戶股權分散表 - 2317 
        /// </summary>
        /// <returns></returns>
        public string Excute()
        {
            IWebDriver driver = new ChromeDriver();
            string resultMessage = string.Empty;

            //開啟網頁
            driver.Navigate().GoToUrl(url);
            //隱式等待
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10000);
            Thread.Sleep(2000);
            //輸入2317
            driver.FindElement(By.Id("StockNo")).SendKeys("2317");
            Thread.Sleep(2000);
            //查詢
            driver.FindElement(By.Name("sub")).Click();
            Thread.Sleep(2000);

            //等待頁面下面的Table出現
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5000));
            IWebElement element = wait.Until(s => s.FindElement(By.XPath("//td[@class='bw09']")));

            //讀取渲染後的Html
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(driver.PageSource);//載入目前頁面的Html原始碼檔案            
            Thread.Sleep(2000);
            //Xpath Tag- 人數
            var peopleTotal = doc.DocumentNode.SelectSingleNode("/html/body/form/table/tbody/tr/td/table[7]/tbody/tr[17]/td[3]").InnerHtml;

            //Xpath Tag- 股　　數/單位數
            var unitTotal = doc.DocumentNode.SelectSingleNode("/html/body/form/table/tbody/tr/td/table[7]/tbody/tr[17]/td[4]").InnerHtml;

            //Xpath Tag-佔集保庫存數比例 (%)
            var percentTotal = doc.DocumentNode.SelectSingleNode("/html/body/form/table/tbody/tr/td/table[7]/tbody/tr[17]/td[5]").InnerHtml;

            resultMessage = "公司：鴻海  代號：2317\r\n";
            resultMessage = string.Format("{0}人數 - 合計： {1}\r\n", resultMessage, peopleTotal);
            resultMessage = string.Format("{0}股　　數/單位數 (%) - 合計： {1}\r\n", resultMessage, unitTotal);
            resultMessage = string.Format("{0}佔集保庫存數比例 (%) - 合計： {1}\r\n", resultMessage,percentTotal);

            driver.Quit();

            return resultMessage;
        }

    }
}
