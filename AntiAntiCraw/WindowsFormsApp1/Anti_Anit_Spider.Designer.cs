namespace WindowsFormsApp1
{
    partial class Anti_Anit_Spider
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox_temp = new System.Windows.Forms.PictureBox();
            this.label_image = new System.Windows.Forms.Label();
            this.label_Message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_temp)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox1.Location = new System.Drawing.Point(263, 222);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 228);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 18F);
            this.button1.Location = new System.Drawing.Point(12, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "驗證碼辨識簡易";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 18F);
            this.button2.Location = new System.Drawing.Point(12, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "模擬人類行為";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 18F);
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "加入Header";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 18F);
            this.button4.Location = new System.Drawing.Point(10, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(247, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "變更IP來源";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("新細明體", 18F);
            this.button5.Location = new System.Drawing.Point(12, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(247, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "驗證碼辨識困難";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox_temp
            // 
            this.pictureBox_temp.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_temp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_temp.Location = new System.Drawing.Point(265, 34);
            this.pictureBox_temp.Name = "pictureBox_temp";
            this.pictureBox_temp.Size = new System.Drawing.Size(498, 160);
            this.pictureBox_temp.TabIndex = 6;
            this.pictureBox_temp.TabStop = false;
            // 
            // label_image
            // 
            this.label_image.AutoSize = true;
            this.label_image.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_image.Location = new System.Drawing.Point(425, 9);
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(154, 24);
            this.label_image.TabIndex = 7;
            this.label_image.Text = "驗證碼圖片區";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Message.Location = new System.Drawing.Point(462, 195);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(82, 24);
            this.label_Message.TabIndex = 8;
            this.label_Message.Text = "訊息區";
            // 
            // Anti_Anit_Spider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.label_image);
            this.Controls.Add(this.pictureBox_temp);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Anti_Anit_Spider";
            this.Text = "Anti_Anit_Spider(反反爬蟲介紹)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_temp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox_temp;
        private System.Windows.Forms.Label label_image;
        private System.Windows.Forms.Label label_Message;
    }
}

