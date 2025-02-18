﻿using System.Windows;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


namespace SubFixy
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // appcenter app analytics connection.
            AppCenter.Start("dd6bfde3-a13b-4c47-a73c-7c315b949b6b", typeof(Analytics), typeof(Crashes));

        }
    }

}

