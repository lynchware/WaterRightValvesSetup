using WaterRightValves.ViewModel;

namespace WaterRightValves.Pages;

public partial class MACAddress : ContentPage
{
	public MACAddress(MACViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}