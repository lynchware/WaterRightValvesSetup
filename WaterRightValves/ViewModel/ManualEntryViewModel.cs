using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WaterRightValves.Pages;

namespace WaterRightValves.ViewModel
{
    public partial class ManualEntryViewModel : ObservableObject
    {
        [ObservableProperty]
        public string _macAddress;

        [RelayCommand]
        async Task OnBackClicked()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task OnNextClicked()
        {
            await Shell.Current.GoToAsync(nameof(WiFiSelection));
        }
        [RelayCommand]
        void OnMacAddressSubmit()
        {
            Shell.Current.GoToAsync($"{nameof(WiFiSelection)}?MacAddress={_macAddress}");
        }
    }
}
