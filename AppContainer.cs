using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();

            AeroPeekEnabled = false;
            TabRenderer = new ChromeTabRenderer(this);
        }

        // Handle the method CreateTab that allows the user to create a new Tab
        // on your app when clicking
        public override TitleBarTab CreateTab()
        {
            
            return new TitleBarTab(this)
            {
                // The content will be an instance of another Form
                // In our example, we will create a new instance of the Form1
                Content = new frmBrowser
                {
                    Text = " "
                }
            };
        }

    }
}
