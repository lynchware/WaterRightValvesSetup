// File: Platforms/Android/WifiScanReceiver.cs
using Android.Content;
using Android.Net.Wifi;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WaterRightValues.Services
{
    public class WifiScanReceiver : BroadcastReceiver
    {
        public event EventHandler<List<ScanResult>> ScanResultsAvailable;

        public override void OnReceive(Context context, Intent intent)
        {
            if(intent.Action.Equals(WifiManager.ScanResultsAvailableAction))
            {
                var wifiManager = (WifiManager)context.GetSystemService(Context.WifiService);
                var scanResults = wifiManager.ScanResults.ToList();
                ScanResultsAvailable?.Invoke(this, scanResults);
            }
        }
    }
}
