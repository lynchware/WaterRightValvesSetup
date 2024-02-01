// File: Platforms/iOS/WiFiService.ios.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterRightValues.Services;

namespace WaterRightValues.Services
{
    internal static partial class WiFiService
    {
        internal static partial List<string> ScanWiFiNetworksAsync()
        {
            // iOS does not support scanning for WiFi networks programmatically
            // You can return an empty list or handle accordingly
            return new List<string>();
        }

        // ... Your existing iOS-specific methods ...
    }
}
