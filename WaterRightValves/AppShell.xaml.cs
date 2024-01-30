using WaterRightValves.Pages;

namespace WaterRightValves
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MACAddress), typeof(MACAddress));
            Routing.RegisterRoute(nameof(WiFiSelection), typeof(WiFiSelection));
            Routing.RegisterRoute(nameof(WiFiPassword), typeof(WiFiPassword));
            Routing.RegisterRoute(nameof(Confirmation), typeof(Confirmation));
        }
    }
}
