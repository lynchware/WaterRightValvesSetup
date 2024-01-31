////#if ANDROID
//using Android.Content;
//using Android.Net.Wifi;
//using Android.App;
//using Application = Microsoft.Maui.ApplicationModel;

//[assembly: Dependency(typeof(WiFiService))]
//namespace WaterRightValves.Services
//{
//    public class WiFiService : BroadcastReceiver, IWiFiService
//    {
//        private readonly WifiManager _wifiManager;
//        private readonly Context _context;
//        public event EventHandler<IList<string>> ScanResultsAvailable;

//        public WiFiService()
//        {
//            _context = Application.CurrentActivity ?? throw new InvalidOperationException("CurrentActivity is null");
//            _wifiManager = (WifiManager)_context.GetSystemService(Context.WifiService);
//        }

//        public override void OnReceive(Context context, Intent intent)
//        {
//            if (intent.Action.Equals(WifiManager.ScanResultsAvailableAction))
//            {
//                IList<string> results = _wifiManager.ScanResults.Select(scanResult => scanResult.Ssid).ToList();
//                ScanResultsAvailable?.Invoke(this, results);
//            }
//        }

//        public void StartScan()
//        {
//            _context.RegisterReceiver(this, new IntentFilter(WifiManager.ScanResultsAvailableAction));
//            _wifiManager.StartScan();
//        }
//   }
//}
////#endif
