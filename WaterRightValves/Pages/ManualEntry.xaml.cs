using System.Text.RegularExpressions;
using WaterRightValves.ViewModel;

namespace WaterRightValves.Pages;

public partial class ManualEntry : ContentPage
{
    public ManualEntry(ManualEntryViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }

    public void macAddressEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = (Entry)sender;
        var formattedText = FormatMacAddress(entry.Text);

        // Disconnect the event handler to prevent an infinite loop
        entry.TextChanged -= macAddressEntry_TextChanged;

        entry.Text = formattedText;

        // Reconnect the event handler
        entry.TextChanged += macAddressEntry_TextChanged;

        // Set the cursor position to the end
        entry.CursorPosition = entry.Text.Length;
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