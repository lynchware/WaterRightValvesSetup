using WaterRightValves.ViewModel;

namespace WaterRightValves.Pages;

public partial class WiFiPassword : ContentPage
{
	public WiFiPassword(WiFiPassViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}