using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Runtime.Serialization;
using WaterRightValves.Pages;


namespace WaterRightValves.ViewModel
{
    public partial class MACViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _aquireMacProgress;
        [ObservableProperty]
        private string _aquiringLabel;
        [ObservableProperty]
        private string _macAddress;

        private bool isAcquiring;
        private int dotCount;
        public MACViewModel()
        {
            AcquireMacAddress();
            isAcquiring = true;
            AnimateEllipsis();
        }

        private async void AnimateEllipsis()
        {
            while(isAcquiring)
            {
                await Task.Delay(1000); // Delay for 1 second
                dotCount = (dotCount + 1) % 4; // Cycle dotCount between 0 and 3

                AquiringLabel = "Acquiring MAC Address" + new string('.', dotCount);
            }
        }

        public async void StopAcquiring()
        {
            if(MacAddress == null)
            {
                await Shell.Current.GoToAsync(nameof(ManualEntry));
            }
            isAcquiring = false;
        }

        private async void AcquireMacAddress()
        {
            // Simulate the progress of acquiring the MAC address
            AquireMacProgress = 0.20;
            await Task.Delay(2000);
            AquireMacProgress = 0.50;
            await Task.Delay(2000);
            AquireMacProgress = 0.70;
            await Task.Delay(1000);
            AquireMacProgress = 1.0;
            StopAcquiring();
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
    }
}
