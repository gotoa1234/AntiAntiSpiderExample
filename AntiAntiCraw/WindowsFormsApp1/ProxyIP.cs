using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ProxyIP
    {

        /// <summary>
        /// Url :  What is my IP
        /// <para>Proxy免費網 http://www.freeproxylists.net/zh/ </para>
        /// </summary>
        private readonly string url = "https://whatismyipaddress.com/";

        /// <summary>
        /// 設定Proxy IP 連到檢查自己的IP位址網站
        /// </summary>
        public ProxyIP()
        {
            //Chrome Service 設定功能
            var cService = ChromeDriverService.CreateDefaultService();
            cService.HideCommandPromptWindow = true;
            var options = new ChromeOptions();

            //設定Proxy IP  
            string pIpv4 = "194.67.57.80";
            string pPort = "3128";
            options.AddArguments( string.Format("--proxy-server={0}:{1}",pIpv4,pPort));
            
            //Set Option & Director
            IWebDriver driver = new ChromeDriver(cService, options);
            driver.Navigate().GoToUrl(this.url);
            Thread.Sleep(50000); 

            driver.Quit();
        }

    }
}
