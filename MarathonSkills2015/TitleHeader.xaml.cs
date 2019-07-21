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
    /// 
    
    public sealed partial class TitleHeader : Page
    {
        private DateTime MDate = new DateTime(DateTime.Now.Year, 9, 5, 6, 0, 0);
        public TitleHeader()
        {
            this.InitializeComponent();
            this.InitiliazeMarathonDate();
        }
        private void InitiliazeMarathonDate()
        {

            DateTime Now = DateTime.Now;
            TimeSpan DatesRemaining = TimeSpan.FromMinutes((int)(MDate - Now).TotalMinutes);
            if (DatesRemaining.TotalSeconds < 0)
            {
                MDate.AddYears(1);
            }
            MarathonDate.Text = MDate.ToLongDateString();

        }
    }
    
}
