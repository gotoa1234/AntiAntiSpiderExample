using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 增加Header 功能
    /// </summary>
    public class CrackHeader
    {
        public CrackHeader()
        {
        }

        /// <summary>
        /// 塞入Header 取資料 
        /// </summary>
        /// <returns>True:進入網站並成功得到回傳  False:失敗</returns>
        public bool Execute()
        {
            try
            {
                using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
                {
                    client.Encoding = Encoding.UTF8;
                    //關鍵的Header
                    client.Headers.Add("token", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbF9mb3JfYXBpX2FjY2VzcyI6ImpvaG5AbmFkZXIubXgifQ.YPt3Eb3xKekv2L3KObNqMF25vc2uVCC-aDPIN2vktmA");
                    client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36");

                    client.Headers.Add(HttpRequestHeader.Host, "stuff.yout.com");
                    client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    client.Headers.Add("Content-Language", "en-US");
                    client.Headers.Add("Content-Type", "application/json");
                    client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    client.Headers.Add(HttpRequestHeader.Referer, "https://yout.com/s?terms=%E8%B7%B3%E8%88%9E");
                    client.Headers.Add("Content-Type: multipart/form-data");
                    client.Headers.Add("Accept-Encoding: gzip, deflate");
                    client.Headers.Add("Cache-Control: no-cache");

                    var body = client.DownloadString("http://stuff.yout.com/s?q=%26%2336339;%26%2333310;");
                    return true;
                }
            }
            catch (Exception ex)
            {
            }

            return false;
        }
    }

   
        

}
