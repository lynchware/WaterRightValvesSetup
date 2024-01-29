using WaterRightValves.ViewModel;

namespace WaterRightValves.Pages;

public partial class Instructions : ContentPage
{
	public Instructions(InstructionsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}