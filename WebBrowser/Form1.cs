using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Permissions;
using System.IO;
using System.Web;
using System.Net;
namespace WebBrowser
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // OurFunction();
        }
        public Form1(string url)
        {
            InitializeComponent();

            // 打开用户主页.
            // 以下事件在设计器中不可见.
            webBrowser1.CanGoBackChanged +=
                new EventHandler(webBrowser1_CanGoBackChanged);
            webBrowser1.CanGoForwardChanged +=
                new EventHandler(webBrowser1_CanGoForwardChanged);
            webBrowser1.DocumentTitleChanged +=
                new EventHandler(webBrowser1_DocumentTitleChanged);
            webBrowser1.StatusTextChanged +=
                new EventHandler(webBrowser1_StatusTextChanged);

            if (url == string.Empty)
                webBrowser1.GoHome();
            else
                webBrowser1.Navigate(url);
        }

        private void openHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Htm文件(*.htm)|*.htm|Html文件(*.html)|*.html"; //设置“另存为文件类型”或“文件类型”框中出现的选择内容
            ofd.FilterIndex = 1; //设置默认显示文件类型为Jpg文件(*.jpg)|*.jpg
            ofd.Title = "选择Html文件"; //获取或设置文件对话框标题
            ofd.InitialDirectory = Application.StartupPath;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                toolStripTextBox1.Text = ofd.FileName;
            }
            else
            {
                return;
            }


        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPageSetupDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }
        // private System.Windows.Forms.WebBrowser final;
        public void OurFunction()
        {
            Thread t = new Thread(new ThreadStart(Thread2));
            t.SetApartmentState(ApartmentState.STA);//就是加上这段代码
            t.IsBackground = true;
            t.Start();
        }
        public string un;
        public string pwd;
        public void OurFunction2(string username,string password)
        {
            un = username;
            pwd = password;
      
        }

    
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Navigate("https://ehall.jlu.edu.cn/infoplus/form/BKSMRDK/start"); 
            //System.Threading.Thread.Sleep(5000);
            //Navigate("https://ehall.jlu.edu.cn");


            Thread t = new Thread(new ThreadStart(Thread2));
            t.SetApartmentState(ApartmentState.STA);//就是加上这段代码
            t.IsBackground = true;
            t.Start();


            
        }
        private string GetHtmlSource(string Url)
        {
            string text1 = "";
            try
            {
                System.Net.WebClient wc = new WebClient();
                text1 = wc.DownloadString(Url);
            }
            catch (Exception exception1)
            { }
            return text1;
        }
        private void Thread2()
        {
            Thread3 t5 = new Thread3(Thread11);
            Thread3 t6 = new Thread3(Thread12);
            Thread3 t3 = new Thread3(Thread4);
            Thread3 t4 = new Thread3(Thread5);
            this.Invoke(t5);
            System.Threading.Thread.Sleep(5000);
            this.Invoke(t6);
            System.Threading.Thread.Sleep(5000);
            this.Invoke(t4);
            System.Threading.Thread.Sleep(5000);
            this.Invoke(t3);
            System.Threading.Thread.Sleep(5000);
            this.Invoke(t3);
            
        }
        public void Thread5()
        {
            Navigate("https://ehall.jlu.edu.cn/infoplus/form/BKSMRDK/start");
        }
        public delegate void Thread3();
        public void Thread11()
        {
            Navigate("https://ehall.jlu.edu.cn");
        }
        public void Thread12()
        {
            HtmlElement tbUserid = webBrowser1.Document.GetElementById("username");
            HtmlElement tbPasswd = webBrowser1.Document.GetElementById("password");
            HtmlElement btnSubmit = webBrowser1.Document.GetElementById("login-submit");
            if (tbUserid == null || tbPasswd == null || btnSubmit == null)
            {
                return;
            }

            //设置元素value属性值 (用户名 密码值)
            tbUserid.SetAttribute("value", un);
            tbPasswd.SetAttribute("value", pwd);

            //执行元素的方法：如click submit  https://ehall.jlu.edu.cn
            btnSubmit.InvokeMember("click");
        }
        public void Thread4()
        {

            
            Console.WriteLine("Test In");
            HtmlElement t = webBrowser1.Document.GetElementById("V1_CTRL28");
            t.InvokeMember("click");
            //System.Threading.Thread.Sleep(5000);
            HtmlElementCollection btnSubmit = webBrowser1.Document.GetElementsByTagName("a");
            for (int i = 0; i < btnSubmit.Count; i++)
            {
                Console.WriteLine(i + ":" + btnSubmit[i].GetAttribute("className"));
                if (btnSubmit[i].GetAttribute("className") == "command_button_content")
                {
                    HtmlElement btnSubmit2 = btnSubmit[i];

                    Console.WriteLine("Find Submit");
                    btnSubmit2.InvokeMember("click");
                    break;
                }
            }
            System.Threading.Thread.Sleep(5000);

            HtmlElementCollection btnSubmit1 = webBrowser1.Document.GetElementsByTagName("button");
            for (int i = 0; i < btnSubmit1.Count; i++)
            {
                if (btnSubmit1[i].GetAttribute("className") == "dialog_button default fr")
                {
                    HtmlElement btnSubmit2 = btnSubmit1[i];
                    Console.WriteLine("Find Ok");
                    btnSubmit2.InvokeMember("click");
                    break;
                }
            }
            Console.WriteLine("Test Out");
        }
        private void Thread1()//回调处理
        {
            //Console.WriteLine("这是无参的方法");
            //Navigate("https://ehall.jlu.edu.cn");
            //Navigate("https://ehall.jlu.edu.cn/infoplus/form/BKSMRDK/start");

            System.Windows.Forms.WebBrowser wb = new System.Windows.Forms.WebBrowser();
            wb.ScriptErrorsSuppressed = true;
            wb.Navigate("about:blank");
            string htmlcode = GetHtmlSource("https://ehall.jlu.edu.cn/infoplus/form/BKSMRDK/start");

            wb.Document.Write(htmlcode);
            HtmlElementCollection t = wb.Document.GetElementsByTagName("title");
            Console.WriteLine(t[0].InnerText);
            Console.WriteLine("Test In");

            System.Threading.Thread.Sleep(5000);
            HtmlElementCollection btnSubmit = wb.Document.GetElementsByTagName("a");
            for (int i = 0; i < btnSubmit.Count; i++)
            {
                Console.WriteLine(i + ":" + btnSubmit[i].GetAttribute("className"));
                if (btnSubmit[i].GetAttribute("className") == "command_button_content")
                {
                    HtmlElement btnSubmit2 = btnSubmit[i];

                    Console.WriteLine("Find Submit");
                    btnSubmit2.InvokeMember("click");
                    break;
                }
            }
            System.Threading.Thread.Sleep(5000);

            HtmlElementCollection btnSubmit1 = wb.Document.GetElementsByTagName("button");
            for (int i = 0; i < btnSubmit1.Count; i++)
            {
                if (btnSubmit1[i].GetAttribute("className") == "dialog_button default fr")
                {
                    HtmlElement btnSubmit2 = btnSubmit1[i];
                    Console.WriteLine("Find Ok");
                    btnSubmit2.InvokeMember("click");
                    break;
                }
            }
            Console.WriteLine("Test Out");
        }
        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPropertiesDialog();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.SelectAll();
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(toolStripTextBox1.Text);
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {

            Navigate(toolStripTextBox1.Text);

        }

        private void Navigate(String address)
        {
            Console.WriteLine("Navigate");
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }

            #region 网址自动处理
            /*
            if (address.IndexOf(".") > 0)
            {
                if (!address.StartsWith("http://") && !address.StartsWith("https://"))
                {
                    address = "http://" + address;
                }
                try
                {
                    webBrowser1.Navigate(new Uri(address));
                }
                catch (System.UriFormatException)
                {
                    return;
                }
            }
            else
            {
                string uri = "https://www.bing.com/search?q=" + HttpUtility.UrlEncode(toolStripTextBox1.Text, Encoding.UTF8);

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader readerstream = new StreamReader(stream, Encoding.UTF8);
                webBrowser1.DocumentText = readerstream.ReadToEnd();
                readerstream.Close();
                stream.Close();
                toolStripTextBox1.Text = uri;
                webBrowser1.Url = new Uri(uri);
            }
           */
            #endregion
        }
        public bool temp = false;
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            temp = false;
            Console.WriteLine("webBrowser1_NavigatedIn");
            toolStripTextBox1.Text = webBrowser1.Url.ToString();
            Console.WriteLine("webBrowser1_NavigatedOut");
            temp = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            backButton.Enabled = webBrowser1.CanGoBack;
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            forwardButton.Enabled = webBrowser1.CanGoForward;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            // 如果地址为 "about:blank" , 避免刷新.
            if (!webBrowser1.Url.Equals("about:blank"))
                webBrowser1.Refresh();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void webBrowser1_StatusTextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = webBrowser1.StatusText;
        }

        // 用当前网页文档的标题取代窗口标题.
        private void webBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = webBrowser1.DocumentTitle;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Dispose();
            Application.Exit();
        }

        private void CodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 显示网页源码的对话框显示出来
            CodeView dialogCodeView = new CodeView();
            dialogCodeView.Text = webBrowser1.Url.ToString() + " - 原始源";
            dialogCodeView.Show();

            // 把网页源码显示在弹出的窗口中
            // 首先解码
            //StreamReader reader = new StreamReader(webBrowser1.DocumentStream, Encoding.GetEncoding("GB2312"));
            //StreamReader reader = new StreamReader(webBrowser1.DocumentStream, Encoding.UTF8);
            StreamReader reader = new StreamReader(webBrowser1.DocumentStream, Encoding.Default);
            dialogCodeView.sourceCode = reader.ReadToEnd();
            reader.Close();
        }

        // 单击程序中某个链接后会打开新窗口，此时就会执行NewWinow事件中的代码
        // 通过此事件中的代码将打开新窗口中内容添加到本软件的webBrowser控件中显示
        // 实现网页用我们自定义的浏览器显示
        private void webBrowser1_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string newURL = webBrowser1.StatusText;
            Form1 newform = new Form1(newURL);
            newform.toolStripStatusLabel1.Text = "正在打开网页 " + newURL + " ...";
            newform.Show();
            // 使其他浏览器无法捕获此事件
            // 阻止了其他浏览器显示网页，而是采用我们自定义的浏览器来显示
            e.Cancel = true;
        }

    }
}
