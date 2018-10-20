using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exam
{
    public partial class mainForm : Form
    {
        //登录页面地址
        string login_url = "http://www.jinmei.com";
        
        //答案页面地址前部分
        string std_answer_a = "http://www.jinmei.com:8099/Examination/AnswerPaper.aspx?PaperId=";
        
        //答案页面地址后部分
        string std_answer_b = "&Type=813B1687B1EE30B91210D2567F4283FB&examid=3535";

        //考试页面地址变量，检测到该地址时直接打开，去除框架
        string exam_sys;
        string my_exam;

        //答案数组
        string[] an = new string[45];

        //临时变量
        string tmp;

        public mainForm()
        {
            InitializeComponent();
        }

        //登录按钮事件
        private void login_button_Click(object sender, EventArgs e)
        {
            main_webBrowser.Navigate(login_url);

            if (continue_radioButton.Checked == true)
            {
                exam_sys = "http://www.jinmei.com:8099/Interface/index.aspx";
                my_exam = "http://www.jinmei.com:8099/Examination/MyExam.aspx";
            }
            else
            {
                exam_sys = "http://www.jinmei.com:8099/Interface/index.aspx";
                my_exam = "http://www.jinmei.com:8099/Examination/ExamCustom.aspx";
            }
        }
                
        private void main_webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //每次更换页面，向url_textBox填入当前url
            url_textBox.Text = main_webBrowser.Url.ToString();

            //当点击自主考试时，强制去除框架
            if (main_webBrowser.Url.ToString() == exam_sys)
            {
                main_webBrowser.Navigate(my_exam);
            }

            //寻找PaperId
            if (url_textBox.Text.IndexOf("PaperId") != -1)
            {
                paperid_textBox.Text = url_textBox.Text.Substring(url_textBox.Text.IndexOf("PaperId") + 8 ,16);
            }
        }

        //强制在当前窗口打开页面
        private void main_webBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            WebBrowser wbt = (WebBrowser)sender;
            main_webBrowser.Navigate(wbt.Document.ActiveElement.GetAttribute("href"));
            e.Cancel = true;
        }

        //答案抓取
        private void getanswer_button_Click(object sender, EventArgs e)
        {
            string answer_url_all = std_answer_a + paperid_textBox.Text + std_answer_b;
            hide_webBrowser.Navigate(answer_url_all);
        }

        //以下执行一系列答案抓取代码，格式化后填入an数组，并显示在answer_richTextBox中
        private void hide_webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            an[0] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl00_lblStandardAnswer").InnerText;
            an[1] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl01_lblStandardAnswer").InnerText;
            an[2] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl02_lblStandardAnswer").InnerText;
            an[3] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl03_lblStandardAnswer").InnerText;
            an[4] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl04_lblStandardAnswer").InnerText;
            an[5] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl05_lblStandardAnswer").InnerText;
            an[6] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl06_lblStandardAnswer").InnerText;
            an[7] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl07_lblStandardAnswer").InnerText;
            an[8] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl08_lblStandardAnswer").InnerText;
            an[9] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl09_lblStandardAnswer").InnerText;

            an[10] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl10_lblStandardAnswer").InnerText;
            an[11] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl11_lblStandardAnswer").InnerText;
            an[12] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl12_lblStandardAnswer").InnerText;
            an[13] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl13_lblStandardAnswer").InnerText;
            an[14] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl14_lblStandardAnswer").InnerText;
            an[15] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl15_lblStandardAnswer").InnerText;
            an[16] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl16_lblStandardAnswer").InnerText;
            an[17] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl17_lblStandardAnswer").InnerText;
            an[18] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl18_lblStandardAnswer").InnerText;
            an[19] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl19_lblStandardAnswer").InnerText;

            an[20] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl20_lblStandardAnswer").InnerText;
            an[21] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl21_lblStandardAnswer").InnerText;
            an[22] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl22_lblStandardAnswer").InnerText;
            an[23] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl23_lblStandardAnswer").InnerText;
            an[24] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl24_lblStandardAnswer").InnerText;
            an[25] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl25_lblStandardAnswer").InnerText;
            an[26] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl26_lblStandardAnswer").InnerText;
            an[27] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl27_lblStandardAnswer").InnerText;
            an[28] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl28_lblStandardAnswer").InnerText;
            an[29] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl29_lblStandardAnswer").InnerText;

            an[30] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl30_lblStandardAnswer").InnerText;
            an[31] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl31_lblStandardAnswer").InnerText;
            an[32] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl32_lblStandardAnswer").InnerText;
            an[33] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl33_lblStandardAnswer").InnerText;
            an[34] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl34_lblStandardAnswer").InnerText;
            an[35] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl35_lblStandardAnswer").InnerText;
            an[36] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl36_lblStandardAnswer").InnerText;
            an[37] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl37_lblStandardAnswer").InnerText;
            an[38] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl38_lblStandardAnswer").InnerText;
            an[39] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl39_lblStandardAnswer").InnerText;
            an[40] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl40_lblStandardAnswer").InnerText;
            an[41] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl41_lblStandardAnswer").InnerText;
            an[42] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl42_lblStandardAnswer").InnerText;
            an[43] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl43_lblStandardAnswer").InnerText;
            an[44] = hide_webBrowser.Document.GetElementById("dlQuestions_ctl44_lblStandardAnswer").InnerText;

            for (int i = 0; i < 45; i++)
            {
                answer_richTextBox.AppendText(an[i] + "\r\n");
            }
            
        }

        //将已抓取的答案投递到考试页面
        private void postanswer_button_Click(object sender, EventArgs e)
        {
            //投递单选题
            for (int i = 0; i < 10; i++ )
            {
                switch (an[i].Substring(0,1))
                {
                    case "A":
                        main_webBrowser.Document.GetElementById("dlQuestions_ctl0" + i.ToString() + "_rbSingleOptions_0").SetAttribute("checked", "true");
                        break;
                    case "B":
                        main_webBrowser.Document.GetElementById("dlQuestions_ctl0" + i.ToString() + "_rbSingleOptions_1").SetAttribute("checked", "true");
                        break;
                    case "C":
                        main_webBrowser.Document.GetElementById("dlQuestions_ctl0" + i.ToString() + "_rbSingleOptions_2").SetAttribute("checked", "true");
                        break;
                    case "D":
                        main_webBrowser.Document.GetElementById("dlQuestions_ctl0" + i.ToString() + "_rbSingleOptions_3").SetAttribute("checked", "true");
                        break;
                }
            }

            //投递多选题
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < an[i + 10].Length;j++ )
                {
                    if (j == 0)
                    {
                        switch (an[i + 10].Substring(0, 1))
                        {
                            case "A":
                                main_webBrowser.Document.GetElementById("dlQuestions_ctl1" + i.ToString() + "_cbMultiOptions_0").SetAttribute("checked", "checked");
                                break;
                            case "B":
                                main_webBrowser.Document.GetElementById("dlQuestions_ctl1" + i.ToString() + "_cbMultiOptions_1").SetAttribute("checked", "checked");
                                break;
                            case "C":
                                main_webBrowser.Document.GetElementById("dlQuestions_ctl1" + i.ToString() + "_cbMultiOptions_2").SetAttribute("checked", "checked");
                                break;
                            case "D":
                                main_webBrowser.Document.GetElementById("dlQuestions_ctl1" + i.ToString() + "_cbMultiOptions_3").SetAttribute("checked", "checked");
                                break;
                        }
                    }

                    if (an[i + 10].Substring(j, 1) == " " && j != 0 && j != an[i + 10].Length - 1)
                    {
                        switch (an[i+10].Substring((j+1), 1))
                        {
                            case "A":
                                main_webBrowser.Document.GetElementById("dlQuestions_ctl1" + i.ToString() + "_cbMultiOptions_0").SetAttribute("checked", "checked");
                                break;
                            case "B":
                                main_webBrowser.Document.GetElementById("dlQuestions_ctl1" + i.ToString() + "_cbMultiOptions_1").SetAttribute("checked", "checked");
                                break;
                            case "C":
                                main_webBrowser.Document.GetElementById("dlQuestions_ctl1" + i.ToString() + "_cbMultiOptions_2").SetAttribute("checked", "checked");
                                break;
                            case "D":
                                main_webBrowser.Document.GetElementById("dlQuestions_ctl1" + i.ToString() + "_cbMultiOptions_3").SetAttribute("checked", "checked");
                                break;
                        }
                    }
                }
            }

            //投递填空题
            for (int i = 0; i < 10; i++)
            {
                int k = 0;
                for (int j = 0; j < an[i + 20].Length; j++)
                {
                    if (an[i + 20].Substring(j, 1) != " ")
                    {
                        tmp = tmp + an[i + 20].Substring(j, 1);
                    }
                    else
                    {
                        k++;
                        main_webBrowser.Document.GetElementById("dlQuestions_ctl2" + i.ToString() + "_TextBox" + k.ToString()).SetAttribute("value", tmp);
                        tmp = "";
                    }
                }
            }

            //投递判断题
            for (int i = 0; i < 10; i++)
            {
                switch (an[i + 30].Substring(0, 1))
                {
                    case "A":
                        main_webBrowser.Document.GetElementById("dlQuestions_ctl3" + i.ToString() + "_rbSingleOptions_0").SetAttribute("checked", "true");
                        break;
                    case "B":
                        main_webBrowser.Document.GetElementById("dlQuestions_ctl3" + i.ToString() + "_rbSingleOptions_1").SetAttribute("checked", "true");
                        break;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                switch (an[i + 40].Substring(0, 1))
                {
                    case "A":
                        main_webBrowser.Document.GetElementById("dlQuestions_ctl4" + i.ToString() + "_rbSingleOptions_0").SetAttribute("checked", "true");
                        break;
                    case "B":
                        main_webBrowser.Document.GetElementById("dlQuestions_ctl4" + i.ToString() + "_rbSingleOptions_1").SetAttribute("checked", "true");
                        break;
                }
            }

            MessageBox.Show("投递完成，请3分钟后提交试卷。");
        }
    }
}
