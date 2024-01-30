using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WaterRightValves.Pages;

namespace WaterRightValves.ViewModel
{
    [QueryProperty("Brand", "Brand")]
    public partial class WiFiPassViewModel : ObservableObject
    {
        [ObservableProperty]
        public string brand; 

        [RelayCommand]
        async Task OnBackClicked()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task OnNextClicked()
        {
            await Shell.Current.GoToAsync($"{nameof(Confirmation)}?brand={brand}");
        }
    }
}
