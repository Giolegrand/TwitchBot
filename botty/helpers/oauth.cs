using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MetroFramework.Forms;

namespace botty.helpers
{
    public partial class oauth : MetroForm
    {
        public string oCode { get; set; }
        public oauth()
        {
            InitializeComponent();

            metroStyleExtender1.SetApplyMetroTheme(webBrowser1, true);

            metroStyleExtender1.Style = metroStyleManager1.Style;
            metroStyleExtender1.Theme = metroStyleManager1.Theme;

            oCode = string.Empty;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

        }
    }
}
