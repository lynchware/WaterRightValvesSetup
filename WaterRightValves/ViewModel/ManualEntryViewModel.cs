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
        private string _previousInput = string.Empty;
        private string FormatMacAddress(string input)
        {
            // Check if the new input is just the old input with an extra character
            // If so, the user is probably typing normally
            if(input.Length > _previousInput.Length + 1)
            {
                // Handle pasting or other input that isn't just normal typing here
            }

            input = Regex.Replace(input, "[^0-9A-Fa-f]", "");
            input = Regex.Replace(input, ".{2}(?!$)", "$0:");

            if(input.Length > 17)
            {
                input = input.Substring(0, 17);
            }

            _previousInput = input; // Store the new input
            return input;
        }

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
