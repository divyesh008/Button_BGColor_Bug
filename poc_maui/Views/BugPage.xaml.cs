using poc_maui.ViewModels;

namespace poc_maui.Views;

public partial class BugPage : ContentPage
{
	public BugPage()
	{
		InitializeComponent();
	}

    void CheckBox_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        var _vm = (BindingContext as BugPageViewModel);
        _vm.HandleViolationCodeSelection();
    }
}
