namespace WinForm
{
    partial class CreateInterfaceSign
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txt_sign = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_format = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_method = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_timestamp = new System.Windows.Forms.TextBox();
            this.cb_useCurrentDateTime = new System.Windows.Forms.CheckBox();
            this.rtb_v_data = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_secret = new System.Windows.Forms.TextBox();
            this.rtb_msg = new System.Windows.Forms.RichTextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成签名";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_sign
            // 
            this.txt_sign.Location = new System.Drawing.Point(24, 175);
            this.txt_sign.Name = "txt_sign";
            this.txt_sign.Size = new System.Drawing.Size(208, 21);
            this.txt_sign.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "app_key";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(97, 23);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(166, 21);
            this.txt_key.TabIndex = 3;
            this.txt_key.Text = "VanLian.BeiJing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "format";
            // 
            // txt_format
            // 
            this.txt_format.Location = new System.Drawing.Point(97, 91);
            this.txt_format.Name = "txt_format";
            this.txt_format.Size = new System.Drawing.Size(166, 21);
            this.txt_format.TabIndex = 5;
            this.txt_format.Text = "json";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "method";
            // 
            // txt_method
            // 
            this.txt_method.Location = new System.Drawing.Point(323, 23);
            this.txt_method.Name = "txt_method";
            this.txt_method.Size = new System.Drawing.Size(166, 21);
            this.txt_method.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "timestamp";
            // 
            // txt_timestamp
            // 
            this.txt_timestamp.Location = new System.Drawing.Point(97, 126);
            this.txt_timestamp.Name = "txt_timestamp";
            this.txt_timestamp.Size = new System.Drawing.Size(166, 21);
            this.txt_timestamp.TabIndex = 9;
            // 
            // cb_useCurrentDateTime
            // 
            this.cb_useCurrentDateTime.AutoSize = true;
            this.cb_useCurrentDateTime.Location = new System.Drawing.Point(97, 153);
            this.cb_useCurrentDateTime.Name = "cb_useCurrentDateTime";
            this.cb_useCurrentDateTime.Size = new System.Drawing.Size(96, 16);
            this.cb_useCurrentDateTime.TabIndex = 10;
            this.cb_useCurrentDateTime.Text = "使用当前时间";
            this.cb_useCurrentDateTime.UseVisualStyleBackColor = true;
            this.cb_useCurrentDateTime.CheckedChanged += new System.EventHandler(this.cb_useCurrentDateTime_CheckedChanged);
            // 
            // rtb_v_data
            // 
            this.rtb_v_data.Location = new System.Drawing.Point(323, 59);
            this.rtb_v_data.Name = "rtb_v_data";
            this.rtb_v_data.Size = new System.Drawing.Size(465, 333);
            this.rtb_v_data.TabIndex = 11;
            this.rtb_v_data.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "v_data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "secret";
            // 
            // txt_secret
            // 
            this.txt_secret.Location = new System.Drawing.Point(97, 56);
            this.txt_secret.Name = "txt_secret";
            this.txt_secret.Size = new System.Drawing.Size(166, 21);
            this.txt_secret.TabIndex = 7;
            this.txt_secret.Text = "07ECAD519BD6B8CF2DFA712BHT";
            // 
            // rtb_msg
            // 
            this.rtb_msg.Location = new System.Drawing.Point(25, 204);
            this.rtb_msg.Name = "rtb_msg";
            this.rtb_msg.Size = new System.Drawing.Size(286, 159);
            this.rtb_msg.TabIndex = 13;
            this.rtb_msg.Text = "测试环境：\nVanLian.BeiJing\n07ECAD519BD6B8CF2DFA712BHT\nVanLian.TianJin\nYIEC0D529BH6B8LF" +
    "2DF1719B17";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(25, 371);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(285, 21);
            this.txt_url.TabIndex = 15;
            this.txt_url.Text = "http://localhost:19029";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(52, 398);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "dbug";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(105, 398);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "test";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(158, 398);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 16);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.Text = "release";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "调用测试";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtb_result
            // 
            this.rtb_result.Location = new System.Drawing.Point(323, 399);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.Size = new System.Drawing.Size(465, 92);
            this.rtb_result.TabIndex = 20;
            this.rtb_result.Text = "";
            // 
            // CreateInterfaceSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.rtb_result);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.rtb_msg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtb_v_data);
            this.Controls.Add(this.cb_useCurrentDateTime);
            this.Controls.Add(this.txt_timestamp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_secret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_method);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_format);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sign);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateInterfaceSign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建vanlian接口签名";
            this.Load += new System.EventHandler(this.CreateInterfaceSign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_sign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_format;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_method;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_timestamp;
        private System.Windows.Forms.CheckBox cb_useCurrentDateTime;
        private System.Windows.Forms.RichTextBox rtb_v_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_secret;
        private System.Windows.Forms.RichTextBox rtb_msg;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtb_result;
    }
}

