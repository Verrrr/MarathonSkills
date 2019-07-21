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
using System.Diagnostics;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MarathonSkills2015
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DateTime MDate = new DateTime(DateTime.Now.Year, 9, 5, 6, 0, 0);
        public MainPage()
        {
            this.InitializeComponent();
            this.InitializeTimer();
            PageController.Main = this;
            if(MainFrame.Content == null)
            {
                MainFrame.Navigate(typeof(Page1));
            }
        }

        public void InitializeTimer()
        {
            UpdateTimer(null, null);
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,1);
            timer.Tick += UpdateTimer;
            timer.Start();
        }
        public void UpdateTimer(object sender, object e)
        {
            DateTime Now = DateTime.Now;
            TimeSpan DatesRemaining = TimeSpan.FromMinutes((int)(MDate - Now).TotalMinutes);

            if (DatesRemaining.TotalSeconds < 0)
            {
                MDate.AddYears(1);
            }
            String TimeRemaining = "";
            if (DatesRemaining.TotalDays > 0)
            {
                String day = Math.Floor(DatesRemaining.TotalDays) + " day";
                if (DatesRemaining.TotalDays > 1)
                {
                    day += "s";
                }
                TimeRemaining += day+" ";
            }
            if (DatesRemaining.Hours > 0)
            {
                String Hour = DatesRemaining.Hours + " hour";
                if (DatesRemaining.Hours > 1)
                {
                    Hour += "s";
                }
                TimeRemaining += Hour +" ";
            }

            TimeRemaining += TimeRemaining.Length != 0 ? " and " : "";

            if (DatesRemaining.Minutes > 0)
            {
                String Minute = DatesRemaining.Minutes + " minute";
                if (DatesRemaining.Minutes > 1)
                {
                    Minute += "s";
                }
                TimeRemaining += Minute+" ";
            }
            TimeRemaining += "until the race starts!";
            TimerLog.Text = TimeRemaining;
        }
        
    }
}
