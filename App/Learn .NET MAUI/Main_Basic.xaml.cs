using Learn_.NET_MAUI.Basic_C_Folder;

namespace Learn_.NET_MAUI;

public partial class Main_Basic : ContentPage
{
    public Main_Basic()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

		try
		{
			UserInterfaceData u = new UserInterfaceData();

            u.LoadData("method", progresMethod);

            u.LoadData("fs", progresFs);

            u.LoadData("events", progresEvents);

            u.LoadData("elements", progresElements);

            u.LoadData("controls", progresControls);

            u.LoadData("variables", progresVariables);

            //u.LoadData("syntax", progresVariables);
		}
		catch
		{

		}
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FS_Basic());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Varibles_Basic());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Methods_Basic());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Elements_C());
    }

    private async void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Controls_Basic());
    }

    private async void Button_Clicked_5(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Events_basic());
    }

	private async void Button_Clicked_6(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new Syntax());
	}
}