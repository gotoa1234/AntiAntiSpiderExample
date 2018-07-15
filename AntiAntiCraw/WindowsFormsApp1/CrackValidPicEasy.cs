using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 破解驗證碼 簡單版 :容易辨別
    /// </summary>
    public class CrackValidPicEasy
    {
        /// <summary>
        /// Url : 財政部 電子發票整合中心
        /// </summary>
        private readonly string url = "https://www.einvoice.nat.gov.tw/APMEMBERVAN/GeneralCarrier/generalCarrier!apply";

        /// <summary>
        /// HtmlAgility 初始設定
        /// </summary>
        private HtmlWeb _web = new HtmlWeb()
        {
            AutoDetectEncoding = false,
            OverrideEncoding = Encoding.Default   //編碼
        };

        public string GetUrl { get; }
     
        /// <summary>
        /// 破解驗證碼
        /// </summary>
        /// <param name="tx"></param>
        public CrackValidPicEasy(TextBox tx)
        {
            IWebDriver driver = new ChromeDriver();
            IWebElement pictureBox;
            
            //開啟網頁
            driver.Navigate().GoToUrl(url);
            //等待頁面的驗證碼出現 ※顯示初始化完畢
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5000));
            IWebElement element = wait.Until(s => s.FindElement(By.Id("img01")));

            //取得目標-驗證碼圖片 - 目的是座標 + 圖片大小
            pictureBox = driver.FindElement(By.Id("img01"));

            //抓取整張圖片
            Screenshot getWebScreen = ((ITakesScreenshot)driver).GetScreenshot();
            //將整張圖片轉成Image  ※ Byte to Memory
            Image myCapture = BufferToImage(getWebScreen.AsByteArray);
            Bitmap imgCaptcha = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);

            //裁剪驗證碼
            Graphics tmpGraph = Graphics.FromImage(imgCaptcha);
            tmpGraph.Clear(Color.FromArgb(0, 0, 0, 0));
            tmpGraph.DrawImage(
                myCapture,
                new Rectangle(0, 0,
                pictureBox.Size.Width,
                pictureBox.Size.Height),
                //----------------
                new Rectangle(pictureBox.Location.X, pictureBox.Location.Y,
                pictureBox.Size.Width,
                pictureBox.Size.Height 
                ),
                 //指定被切割的圖片要繪製的部分
                 GraphicsUnit.Pixel
            );

            imgCaptcha.Save("D:\\Chapcha.png");

            //辨識圖片內容 
            string engText = string.Empty;

            Thread tt = new Thread(() =>
            {
                engText = GetText(imgCaptcha);
            });
            tt.Start();
            //等待執行緒處理完畢
            tt.Join();
            engText = engText.Trim('\n');
            if (engText == string.Empty)
            {
                tx.AppendText( string.Format("辨識驗證碼： 【失敗】\r\n"));
                engText = "aaaa";
            }
            else
            {
                tx.AppendText( string.Format("辨識驗證碼： 【{0}】\r\n", engText));
            }
            
            //輸入驗證碼
            IWebElement inputBox = driver.FindElement(By.Id("imageCode"));
            inputBox.SendKeys(engText);
            Thread.Sleep(3000);
            driver.Quit();
            
        }

        /// <summary>
        /// Byte[] to Image
        /// </summary>
        /// <param name="Buffer"></param>
        /// <returns></returns>
        private static Image BufferToImage(byte[] Buffer)
        {
            if (Buffer == null || Buffer.Length == 0) { return null; }
            byte[] data = null;
            Image oImage = null;
            Bitmap oBitmap = null;
            //建立副本
            data = (byte[])Buffer.Clone();
            try
            {
                MemoryStream oMemoryStream = new MemoryStream(Buffer);
                //設定資料流位置
                oMemoryStream.Position = 0;
                oImage = System.Drawing.Image.FromStream(oMemoryStream);
                //建立副本
                oBitmap = new Bitmap(oImage);
            }
            catch
            {
                throw;
            }
            //return oImage;
            return oBitmap;
        }

        /// <summary>
        /// 取得驗證碼文字
        /// </summary>
        /// <param name="imgsource"></param>
        /// <returns></returns>
        private static string GetText(Bitmap imgsource)
        {

            var ocrtext = string.Empty;
            using (var engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default))
            {
                using (var img = PixConverter.ToPix(imgsource))
                {
                    using (var page = engine.Process(img))
                    {
                        ocrtext = page.GetText();
                    }
                }
            }

            return ocrtext;
        }

    }
}
