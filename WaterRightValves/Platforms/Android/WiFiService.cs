// File: Platforms/Android/WiFiService.android.cs
using Android.Net.Wifi;
using Android.App;
using Android.Content;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterRightValues.Services;

namespace WaterRightValues.Services
{
    internal static partial class WiFiService
    {
        internal static partial List<string> ScanWiFiNetworksAsync()
        {
            var wifiManager = (WifiManager)Android.App.Application.Context.GetSystemService(Context.WifiService);
            var wifiScanReceiver = new WifiScanReceiver();

            var taskCompletionSource = new TaskCompletionSource<List<ScanResult>>();
            wifiScanReceiver.ScanResultsAvailable += (sender, scanResults) =>
            {
                taskCompletionSource.SetResult(scanResults);
            };

            Android.App.Application.Context.RegisterReceiver(wifiScanReceiver, new IntentFilter(WifiManager.ScanResultsAvailableAction));
            wifiManager.StartScan();

            var scanResults = taskCompletionSource.Task;
            Android.App.Application.Context.UnregisterReceiver(wifiScanReceiver);

            return scanResults.Select(scanResult => scanResult.Ssid).Distinct().ToList();
        }
    }
}
