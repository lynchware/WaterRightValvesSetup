﻿////#if ANDROID
//using Android.Content;
//using Android.Net.Wifi;
//using Android.App;
//using Application = Microsoft.Maui.ApplicationModel;

namespace WaterRightValves.Interfaces
{
    public interface IWiFiService
    {
        Task<List<string>> ScanWiFiNetworksAsync();
        //Task ConfigureHotspotAsync(string ssid, string passphrase);
        //void OpenWiFiSettings();
    }
}