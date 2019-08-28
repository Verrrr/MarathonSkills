using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Data;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MarathonSkills2015
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page6 : Page
    {
        Db db = new Db();
        public Page6()
        {
            this.InitializeComponent();
            PageController.ChangePageTitle("Sponsor a runner");
            this.loadRunners();
        }

        private void loadRunners()
        {
            var data = db.executeQuery("SELECT * FROM charity");
            this.cbRunners.ItemsSource =  data;
            cbRunners.DisplayMemberPath = "CharityId";
            
        }
    }
}
