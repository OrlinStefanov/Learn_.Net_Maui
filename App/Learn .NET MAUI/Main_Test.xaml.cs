using Learn_.NET_MAUI.Test_Folder;

namespace Learn_.NET_MAUI;

public partial class Main_Test : ContentPage
{
    public Main_Test()
    {
        InitializeComponent();
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();

        try
        {
			SaveProgress p = new SaveProgress();

			p.LoadTest(progressUIT1);

		} catch
        {

        }
	}

	private async void UITest1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UITest1());
    }
}