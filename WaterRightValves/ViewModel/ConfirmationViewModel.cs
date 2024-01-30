using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WaterRightValves.ViewModel
{
    [QueryProperty("Brand", "Brand")]
    public partial class ConfirmationViewModel : ObservableObject
    {
        [ObservableProperty]
        public string brand;

        [RelayCommand]
        async Task OnBackClicked()
        {
            await Shell.Current.GoToAsync("..");
        }

    }
}
