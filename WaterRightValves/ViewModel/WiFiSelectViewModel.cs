using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WaterRightValves.Pages;

namespace WaterRightValves.ViewModel
{
    public partial class WiFiSelectViewModel : ObservableObject
    {
        [ObservableProperty]
        public string brand; // This is the property that will be set by the query parameter

        [RelayCommand]
        async Task OnBackClicked()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task OnNextClicked()
        {
            await Shell.Current.GoToAsync($"{nameof(WiFiPassword)}?brand={brand}");
        }
    }
}
