namespace exam
{
    partial class mainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.paperid_textBox = new System.Windows.Forms.TextBox();
            this.pid_label = new System.Windows.Forms.Label();
            this.answer_richTextBox = new System.Windows.Forms.RichTextBox();
            this.main_webBrowser = new System.Windows.Forms.WebBrowser();
            this.hide_webBrowser = new System.Windows.Forms.WebBrowser();
            this.url_textBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.getanswer_button = new System.Windows.Forms.Button();
            this.postanswer_button = new System.Windows.Forms.Button();
            this.url_label = new System.Windows.Forms.Label();
            this.new_radioButton = new System.Windows.Forms.RadioButton();
            this.continue_radioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // paperid_textBox
            // 
            this.paperid_textBox.Location = new System.Drawing.Point(71, 52);
            this.paperid_textBox.Name = "paperid_textBox";
            this.paperid_textBox.Size = new System.Drawing.Size(134, 21);
            this.paperid_textBox.TabIndex = 0;
            // 
            // pid_label
            // 
            this.pid_label.AutoSize = true;
            this.pid_label.Location = new System.Drawing.Point(12, 55);
            this.pid_label.Name = "pid_label";
            this.pid_label.Size = new System.Drawing.Size(53, 12);
            this.pid_label.TabIndex = 1;
            this.pid_label.Text = "PaperID:";
            // 
            // answer_richTextBox
            // 
            this.answer_richTextBox.Location = new System.Drawing.Point(345, 12);
            this.answer_richTextBox.Name = "answer_richTextBox";
            this.answer_richTextBox.Size = new System.Drawing.Size(460, 61);
            this.answer_richTextBox.TabIndex = 3;
            this.answer_richTextBox.Text = "";
            // 
            // main_webBrowser
            // 
            this.main_webBrowser.Location = new System.Drawing.Point(12, 115);
            this.main_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.main_webBrowser.Name = "main_webBrowser";
            this.main_webBrowser.ScriptErrorsSuppressed = true;
            this.main_webBrowser.Size = new System.Drawing.Size(793, 481);
            this.main_webBrowser.TabIndex = 5;
            this.main_webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.main_webBrowser_DocumentCompleted);
            this.main_webBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.main_webBrowser_NewWindow);
            // 
            // hide_webBrowser
            // 
            this.hide_webBrowser.Location = new System.Drawing.Point(735, 235);
            this.hide_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.hide_webBrowser.Name = "hide_webBrowser";
            this.hide_webBrowser.ScriptErrorsSuppressed = true;
            this.hide_webBrowser.Size = new System.Drawing.Size(46, 39);
            this.hide_webBrowser.TabIndex = 6;
            this.hide_webBrowser.Visible = false;
            this.hide_webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.hide_webBrowser_DocumentCompleted);
            // 
            // url_textBox
            // 
            this.url_textBox.Location = new System.Drawing.Point(47, 88);
            this.url_textBox.Name = "url_textBox";
            this.url_textBox.Size = new System.Drawing.Size(758, 21);
            this.url_textBox.TabIndex = 7;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(12, 12);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(101, 30);
            this.login_button.TabIndex = 8;
            this.login_button.Text = "登录考试";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // getanswer_button
            // 
            this.getanswer_button.Location = new System.Drawing.Point(119, 12);
            this.getanswer_button.Name = "getanswer_button";
            this.getanswer_button.Size = new System.Drawing.Size(101, 30);
            this.getanswer_button.TabIndex = 9;
            this.getanswer_button.Text = "抓取答案";
            this.getanswer_button.UseVisualStyleBackColor = true;
            this.getanswer_button.Click += new System.EventHandler(this.getanswer_button_Click);
            // 
            // postanswer_button
            // 
            this.postanswer_button.Location = new System.Drawing.Point(226, 12);
            this.postanswer_button.Name = "postanswer_button";
            this.postanswer_button.Size = new System.Drawing.Size(101, 30);
            this.postanswer_button.TabIndex = 10;
            this.postanswer_button.Text = "投递答案";
            this.postanswer_button.UseVisualStyleBackColor = true;
            this.postanswer_button.Click += new System.EventHandler(this.postanswer_button_Click);
            // 
            // url_label
            // 
            this.url_label.AutoSize = true;
            this.url_label.Location = new System.Drawing.Point(12, 91);
            this.url_label.Name = "url_label";
            this.url_label.Size = new System.Drawing.Size(29, 12);
            this.url_label.TabIndex = 11;
            this.url_label.Text = "URL:";
            // 
            // new_radioButton
            // 
            this.new_radioButton.AutoSize = true;
            this.new_radioButton.Checked = true;
            this.new_radioButton.Location = new System.Drawing.Point(226, 54);
            this.new_radioButton.Name = "new_radioButton";
            this.new_radioButton.Size = new System.Drawing.Size(47, 16);
            this.new_radioButton.TabIndex = 12;
            this.new_radioButton.TabStop = true;
            this.new_radioButton.Text = "新考";
            this.new_radioButton.UseVisualStyleBackColor = true;
            // 
            // continue_radioButton
            // 
            this.continue_radioButton.AutoSize = true;
            this.continue_radioButton.Location = new System.Drawing.Point(277, 54);
            this.continue_radioButton.Name = "continue_radioButton";
            this.continue_radioButton.Size = new System.Drawing.Size(47, 16);
            this.continue_radioButton.TabIndex = 13;
            this.continue_radioButton.TabStop = true;
            this.continue_radioButton.Text = "续考";
            this.continue_radioButton.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 608);
            this.Controls.Add(this.continue_radioButton);
            this.Controls.Add(this.new_radioButton);
            this.Controls.Add(this.url_label);
            this.Controls.Add(this.postanswer_button);
            this.Controls.Add(this.getanswer_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.url_textBox);
            this.Controls.Add(this.hide_webBrowser);
            this.Controls.Add(this.main_webBrowser);
            this.Controls.Add(this.answer_richTextBox);
            this.Controls.Add(this.pid_label);
            this.Controls.Add(this.paperid_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动考试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paperid_textBox;
        private System.Windows.Forms.Label pid_label;
        private System.Windows.Forms.RichTextBox answer_richTextBox;
        private System.Windows.Forms.WebBrowser main_webBrowser;
        private System.Windows.Forms.WebBrowser hide_webBrowser;
        private System.Windows.Forms.TextBox url_textBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button getanswer_button;
        private System.Windows.Forms.Button postanswer_button;
        private System.Windows.Forms.Label url_label;
        private System.Windows.Forms.RadioButton new_radioButton;
        private System.Windows.Forms.RadioButton continue_radioButton;
    }
}

