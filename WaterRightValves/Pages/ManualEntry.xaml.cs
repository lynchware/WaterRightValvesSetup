using System.Text.RegularExpressions;
using WaterRightValves.ViewModel;

namespace WaterRightValves.Pages;

public partial class ManualEntry : ContentPage
{
	private string _previousInput = string.Empty;
    public ManualEntry(ManualEntryViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }

    private void macAddressEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = (Entry)sender;
        entry.Text = FormatMacAddress(e.NewTextValue);
    }

    private string FormatMacAddress(string input)
    {
        if(string.IsNullOrWhiteSpace(input)) return string.Empty;

        // Remove any non-hexadecimal characters
        input = Regex.Replace(input, "[^0-9A-Fa-f]", "");

        // Add a colon (:) after every second character
        var formattedText = Regex.Replace(input, ".{2}(?!$)", "$0:");

        // Truncate to max 17 characters (XX:XX:XX:XX:XX:XX)
        if(formattedText.Length > 17)
        {
            formattedText = formattedText.Substring(0, 17);
        }

        return formattedText;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}