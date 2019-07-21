using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MarathonSkills2015
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NavigationBar : Page
    {
        public NavigationBar()
        {
            this.InitializeComponent();
            PageController.Main.NavRowDefinition.Height = new GridLength(48);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PageController.Main.MainFrame.CanGoBack)
            {
                PageController.Main.MainFrame.GoBack();
            }
        }
    }
}
