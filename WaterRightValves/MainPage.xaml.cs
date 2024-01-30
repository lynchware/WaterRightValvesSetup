using WaterRightValves.Pages;
using WaterRightValves.ViewModel;

namespace WaterRightValves
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if(count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        void OnProductSelect(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if(selectedIndex != -1)
            {
                var brand = (string)picker.ItemsSource[selectedIndex];
                if(selectedIndex == 1)
                {
                    selectedBrand.Text = (string)picker.ItemsSource[selectedIndex];
                }
                else
                {
                    Shell.Current.GoToAsync($"{nameof(Instructions)}?brand={brand}");

                }
            }

        }
    }

}
