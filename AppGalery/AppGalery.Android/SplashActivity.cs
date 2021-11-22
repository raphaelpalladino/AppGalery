using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGalery.Droid
{
    [Activity(Label = "SplashActivity" , MainLauncher = true, Theme = "@style/MainTheme.Splash", ConfigurationChanges = ConfigChanges.ScreenSize)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();
            // Create your application here
            OverridePendingTransition(0, 0);
        }
    }
}