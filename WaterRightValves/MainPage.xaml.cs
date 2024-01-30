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
