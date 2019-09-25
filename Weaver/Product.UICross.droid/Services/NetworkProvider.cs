﻿namespace Product.UICross.droid.Services
{
    using global::Android.Content;
    using global::Android.Net.Wifi;
    using MvvmCross;
    using MvvmCross.Platforms.Android;
    using Weaver.Common.Interfaces;

    public class NetworkProvider : INetworkProvider
    {
        private readonly Context context;

        public NetworkProvider()
        {
            context = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;
        }

        public bool IsConnectedToWifi()
        {
            var wifi = (WifiManager)context.GetSystemService(Context.WifiService);
            return wifi.IsWifiEnabled;
        }
    }
}