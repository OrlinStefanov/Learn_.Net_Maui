//using Android.Webkit;

namespace Learn_.NET_MAUI;

using Plugin.LocalNotification;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var result = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "Come back and learn more about .NET MAUI",
            Description = "There are a lot of lessons and tests you hadn't done",
            BadgeNumber = 42,
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddHours(2),
                NotifyRepeatInterval = TimeSpan.FromDays(1),
            }
        };

        LocalNotificationCenter.Current.Show(result);
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();

        SaveProgress s = new SaveProgress();

        try
        {
            s.LoadUserInterface(progresUS);
            s.LoadBasicC(progresC);

        } catch (Exception ex)
        {
            Console.WriteLine("Error:" + ex.ToString());
        }
	}

	private async void UserInterfaceBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UserInterface());
    }

    private async void FundamentsBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Fundaments());
    }

    private async void Fundamentals2Btn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Main_Basic());
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }
}