using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Doctor
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Form1 : Form
    {

        CookieContainer cook = null;
        public Form1()
        {
            InitializeComponent();
        }

        public void Hello(string aa)
        {
            MessageBox.Show(aa);
        }

        public void test()
        {
            MessageBox.Show("asdaf");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.webBrowser1.ObjectForScripting = this;
            //string path = Application.StartupPath + @"\test.htm";
            string path = "http://192.168.0.221:8081/superscene/test.html";
            path = " http://mcm3.pc.e-health.org.cn";
       
            //MessageBox.Show(path);
            this.webBrowser1.Navigate(path);
            //this.webBrowser1.Url = new System.Uri(path, System.UriKind.Absolute);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.webBrowser1.Document.InvokeScript("winfromForJs", new object[]{"winform 调用 js","我是第二个参数"});
           // this.webBrowser1.Document.InvokeScript("fun");
            if (cook == null) { 
                cook = GetCookieString();
                HttpLoad.getInstance().setCook(cook);
            
            }
            DataConvertWomen.getInstance();
            DataConvertMen.getInstance();
            //this.webBrowser1.Navigate("");
           // this.button1.Visible = false;
            
            //MainService.getInstance().work();
            new Sqlservice().test();
        }


        private CookieContainer GetCookieString()
        {
            // Determine the size of the cookie      
            CookieContainer myCookieContainer = new CookieContainer();

            string cookieStr = this.webBrowser1.Document.Cookie;
            string[] cookstr = cookieStr.Split(';');
            foreach (string str in cookstr)
            {
                string[] cookieNameValue = str.Split('=');
                Cookie ck = new Cookie(cookieNameValue[0].Trim().ToString(), cookieNameValue[1].Trim().ToString());
                ck.Domain = "mcm3.pc.e-health.org.cn";
                myCookieContainer.Add(ck);
            }
            return myCookieContainer;
        }
    }
}
