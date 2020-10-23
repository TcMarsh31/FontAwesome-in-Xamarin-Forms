using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XLFontAwesome
{
    public partial class XLFontAwesomeShell : Shell
    {
        public XLFontAwesomeShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Page1", typeof(MainPage));
            Routing.RegisterRoute("Page2", typeof(MainPage));

        }
    }
}
