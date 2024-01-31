using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WaterRightValves.Pages;
namespace WaterRightValves.ViewModel
{
    [QueryProperty("MacAddress", "MacAddress")]
    public partial class WiFiSelectViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> wiFiNetworks;

        [ObservableProperty]
        string selectedWiFiNetwork;

        [ObservableProperty]
        string macAddress;

        public WiFiSelectViewModel()
        {
            WiFiNetworks = new ObservableCollection<string>(
                CWInterface.InterfaceNames
            ); 
        }
        [RelayCommand]
        private void LoadWiFiNetworks()
        {

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
