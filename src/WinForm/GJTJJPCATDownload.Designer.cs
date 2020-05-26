namespace WinForm
{
    partial class GJTJJPCATDownload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_p_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_msg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_year
            // 
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(35, 175);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(121, 20);
            this.cb_year.TabIndex = 1;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(67, 47);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(335, 21);
            this.txt_url.TabIndex = 2;
            this.txt_url.Text = "http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/";
            // 
            // txt_p_url
            // 
            this.txt_p_url.Location = new System.Drawing.Point(67, 74);
            this.txt_p_url.Name = "txt_p_url";
            this.txt_p_url.Size = new System.Drawing.Size(122, 21);
            this.txt_p_url.TabIndex = 3;
            this.txt_p_url.Text = "{year}/index.html";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "p_url";
            // 
            // rtb_msg
            // 
            this.rtb_msg.HideSelection = false;
            this.rtb_msg.Location = new System.Drawing.Point(238, 77);
            this.rtb_msg.Name = "rtb_msg";
            this.rtb_msg.Size = new System.Drawing.Size(164, 183);
            this.rtb_msg.TabIndex = 5;
            this.rtb_msg.Text = "";
            // 
            // GJTJJPCATDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 339);
            this.Controls.Add(this.rtb_msg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_p_url);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.cb_year);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GJTJJPCATDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "国家统计局省市区镇村下载";
            this.Load += new System.EventHandler(this.GJTJJPCATDownload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_p_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_msg;
    }
}