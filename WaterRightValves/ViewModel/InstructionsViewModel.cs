using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WaterRightValves.Pages;

namespace WaterRightValves.ViewModel
{
    [QueryProperty("Brand", "Brand")]
    public partial class InstructionsViewModel : ObservableObject
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
            await Shell.Current.GoToAsync($"{nameof(MACAddress)}?brand={brand}");
        }
    }
}
