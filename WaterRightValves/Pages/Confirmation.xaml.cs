using WaterRightValves.ViewModel;

namespace WaterRightValves.Pages;

public partial class Confirmation : ContentPage
{
	public Confirmation(ConfirmationViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}