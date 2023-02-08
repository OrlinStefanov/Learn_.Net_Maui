using Learn_.NET_MAUI.Fundamentals;

namespace Learn_.NET_MAUI;

public partial class Fundaments : ContentPage
{
    public Fundaments()
    {
        InitializeComponent();
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();

		try
		{
			UserInterfaceData u = new UserInterfaceData();

			u.LoadData("templates", progressT);
			u.LoadData("databinding", progressDB);
			u.LoadData("datasaving", progresDS);
		}
		catch
		{

		}
	}

	private async void TemplatesBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Templates_Fundamentals());
    }

    private async void DataBindingBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DataBinding_Fundamentals());
    }

    private void FistStepsBtn_Clicked(object sender, EventArgs e)
    {

    }

	private async void Button_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new DataSaving());
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }
}