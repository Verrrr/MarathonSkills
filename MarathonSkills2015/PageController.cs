using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonSkills2015
{
    class PageController
    {
        private static MainPage main;
        public static MainPage Main
        {
            set { main = value; }
            get { return main; }
        }

        public static void ChangePageTitle(String title)
        {
            var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            appView.Title = title;
        }
    }
}
