using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WindowsFormsApp1.WebDriverExample;
using Tesseract;

namespace WindowsFormsApp1
{
    public partial class Anti_Anit_Spider : Form
    {
        public Anti_Anit_Spider()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 1. Header 存值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            CrackHeader headerSave = new CrackHeader();
            textBox1.AppendText(headerSave.Execute() == true ? "成功回傳\r\n" : "失敗\r\n");
        }

        /// <summary>
        /// 2. 變更IP 連網頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            ProxyIP changeIP = new ProxyIP();
        }

        /// <summary>
        /// 3.1 辨識驗證碼 Easy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //CrackValidPic crackValidPic = new CrackValidPic(textBox1);
            CrackValidPicEasy crackValidPic = new CrackValidPicEasy(textBox1);
            //讀取圖片
            this.Load_picture("D:\\Chapcha.png");
        }

        /// <summary>
        /// 3.2 驗證碼 Hard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            CrackValidPic crackValidPic = new CrackValidPic(textBox1);
            //讀取圖片
            this.Load_picture("D:\\Chapcha2.png");
        }

        /// <summary>
        /// 4. 模擬人類行為
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            SimulatedHuman sH = new SimulatedHuman();
            textBox1.AppendText( sH.Excute());
        }


        #region Method

        /// <summary>
        /// 讀取圖片
        /// </summary>
        private void Load_picture(string imgPath)
        {
            pictureBox_temp.ImageLocation = imgPath;
            textBox1.AppendText(string.Format("=> 載入圖片成功! Path: {0} \r\n", imgPath));
        }


        #endregion

    }
}
