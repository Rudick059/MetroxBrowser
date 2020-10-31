using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace Metrox
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new frmBrowser()
                {
                    
                    Text = 
                    "Metro Broswer"
                    
                }
            };
        }

        public new bool ShowTooltips
        {
            get;
            set;
        }
        public new ToolTip Tooltip
        {
            get;
            set;
        }
        public BaseTabRenderer TabRenderer
        {
            get
            {
                return _tabRenderer;
            }

            set
            {
                _tabRenderer = value;
                SetFrameSize();
            }
        }

    }
}
