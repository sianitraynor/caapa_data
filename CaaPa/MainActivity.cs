using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.WindowsAzure.MobileServices;


namespace CaaPa
{
    [Activity(Label = "CaaPa", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        public static MobileServiceClient MobileService = new MobileServiceClient("https://caapa.azure-mobile.net/", "coHzRHuoqnHiolDACEHMunJRIeEJUH21");

        protected override void OnCreate(Bundle bundle){

            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main) { }
        }
    }
}

