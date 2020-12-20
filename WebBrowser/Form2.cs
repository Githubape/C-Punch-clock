using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WebBrowser
{
    public partial class Form2 : Form
    {
        public string userIdContext;
        public string passwdContext;
        DateTime now;
        DateTime dueTime;
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void passwd_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void userIdButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
       public Form1 qform = new Form1();
        private void confirm_Click(object sender, EventArgs e)
        {
            int minuteAndSec = 0;
            minuteAndSec = int.Parse(hour.Text) * 3600 + int.Parse(minute.Text) * 60;
            userIdContext = userId.Text;
            passwdContext = passwd.Text;
            now = DateTime.Now;
            dueTime = DateTime.Parse(dateTimePicker1.Text);
            //   System.Threading.Thread.Sleep(((int)((dueTime - now).TotalSeconds + minuteAndSec) * 1000));
            Console.WriteLine("sleep:{0}", ((int)((dueTime - now).TotalSeconds + minuteAndSec) * 1000));
            //Form1 qform = new Form1();
            Thread t = new Thread(new ThreadStart(Thread9));
            t.SetApartmentState(ApartmentState.STA);//就是加上这段代码
            t.IsBackground = true;
            t.Start();


            qform.ShowDialog();

        }
        public delegate void Thread8(Form1 t);
        public void Thread9()
        {
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Test Thread9");
            Thread8 t = new Thread8(Thread10);
            t(qform);
            System.Threading.Thread.Sleep(2000);
        }
        public void Thread10(Form1 a)
        {  
            a.OurFunction2(userIdContext, passwdContext);
            a.OurFunction();
          
        }

    
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userId_Click(object sender, EventArgs e)
        {

        }
    }
}
