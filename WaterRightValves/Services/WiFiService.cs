#if ANDROID
using Microsoft.Maui;
using WaterRightValves.Interfaces;

namespace WaterRightValves.Services
{
    public class WiFiService : BroadcastReceiver, IWiFiService
    {
        private WifiManager wifiManager;

        public WifiScanReceiver(WifiManager wifiManager)
        {
            this.wifiManager = wifiManager;
        }
        public override void OnReceive(Context context, Intent intent)
        {
            if(intent.Action.Equals(WifiManager.ScanResultsAvailableAction))
            {
                List<ScanResult> scanResults = wifiManager.ScanResults.ToList<ScanResult>();
                if(scanResults != null)
                {
                    foreach(ScanResult scanResult in scanResults)
                    {
                        Console.WriteLine(scanResult.Ssid.ToString());
                    }
                }
            }
        }
    }

#endif
#if IOS
using UIKit;
using NetworkExtension;
using Foundation;
using WaterRightValves.Services;
using System.Threading.Tasks;
using WaterRightValves.Interfaces;

[assembly: Dependency(typeof(WiFiService))]
namespace WaterRightValves.Services
{
    public class WiFiService : IWiFiService
    {
        public async Task ConfigureHotspotAsync(string ssid, string passphrase)
        {
            var configuration = new NEHotspotConfiguration(ssid, passphrase, false);
            await NEHotspotConfigurationManager.SharedManager.ApplyConfigurationAsync(configuration);
        }
        public void OpenWiFiSettings()
        {
            var url = new NSUrl(UIApplication.OpenSettingsUrlString);
            if(UIApplication.SharedApplication.CanOpenUrl(url))
            {
                UIApplication.SharedApplication.OpenUrl(url);
            }
        }
    }

}

#endif
