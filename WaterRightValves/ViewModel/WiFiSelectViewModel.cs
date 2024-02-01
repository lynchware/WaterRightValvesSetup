using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WaterRightValves.Pages;
using WaterRightValves.Interfaces;
namespace WaterRightValves.ViewModel
{
    [QueryProperty("MacAddress", "MacAddress")]
    public partial class WiFiSelectViewModel : ObservableObject
    {
        private readonly IWiFiService _wiFiService;
        [ObservableProperty]
        ObservableCollection<string> wiFiNetworks;

        [ObservableProperty]
        string selectedWiFiNetwork;

        [ObservableProperty]
        string macAddress;

        public WiFiSelectViewModel(IWiFiService wiFiService)
        {
            _wiFiService = wiFiService;
        }
        public bool IsAndroid => DeviceInfo.Platform == DevicePlatform.Android;
        public bool IsiOS => DeviceInfo.Platform == DevicePlatform.iOS;
        [RelayCommand]
        private void OpenWiFiSettings()
        {
            _wiFiService.OpenWiFiSettings();
        }
            [RelayCommand]
        async Task OnBackClicked()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task OnNextClicked()
        {
            await Shell.Current.GoToAsync(nameof(WiFiPassword));
        }
    }
}
