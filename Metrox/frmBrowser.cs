using EasyTabs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrox
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();

            //Upgrade the default web browser
            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);

            //Open Google.com
            webBrowser1.Navigate("https://www.google.com");
        }

        protected TitleBarTabs ParentTabs
        {
            
            get
            {
                return (ParentForm as TitleBarTabs); 
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)   //BackButton
        {
            if (webBrowser1.CanGoBack) webBrowser1.GoBack();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)   //ForwardButton
        {
            if (webBrowser1.CanGoForward) webBrowser1.GoForward();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)   //HomeButton
        {
            webBrowser1.Navigate("https://www.google.com");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)   //RefreshButton
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)  //SearchBoxURL
        {
            guna2TextBox1.Text = webBrowser1.Url
               .AbsoluteUri;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)    //SettingsButton
        {
            MessageBox.Show("Comming Soon");
        }

        private void guna2TextBox1_IconRightClick(object sender, EventArgs e)  //Icon Clear
        {
            guna2TextBox1.Clear();
        }
    }
}
