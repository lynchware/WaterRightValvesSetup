using WaterRightValves.ViewModel;

namespace WaterRightValves.Pages;

public partial class WiFiSelection : ContentPage
{
	public WiFiSelection(WiFiSelectViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}