using Learn_.NET_MAUI.User_Interface;

namespace Learn_.NET_MAUI;

public partial class UserInterface : ContentPage
{
    public UserInterface()
    {
        InitializeComponent();
    }

	protected override void OnAppearing()
	{
		base.OnDisappearing();

        try
        {
			UserInterfaceData u = new UserInterfaceData();

			u.LoadData("firstSteps", progressFS);

            u.LoadData("layouts", progressL);

            u.LoadData("pages", progressP);

            u.LoadData("views1", progressV1);

            u.LoadData("views2", progressV2);

		} catch {
            
        }
	}

	private async void FistStepsBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FS_UserInterface());
    }

    private async void LayoutsBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Layouts_UserInterface());
    }

    private async void PagesBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages_UserInterface());
    }

    private async void ViewsPart1Btn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsP1_UserInterface());
    }

    private async void ViewsPart2Btn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsP2_UserInterface());
    }
}