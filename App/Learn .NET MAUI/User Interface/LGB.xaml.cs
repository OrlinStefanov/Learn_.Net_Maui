namespace Learn_.NET_MAUI;

public partial class LGB : ContentPage
{
    public string[] headText = { "LinearGradientBrush", "Horizontal Linear Gradient", "Vertical Linear Gradient" };

    public string[] mainText = { "The .NET Multi-platform App UI LinearGradientBrush class derives from the GradientBrush class, and paints an area with a linear gradient, which blends two or more colors along a line known as the gradient axis.\r\nGradientStop objects are used to specify the colors in the gradient and their positions. \r\nThe LinearGradientBrush class defines StartPoint and EndPoint.", "To create a horizontal linear gradient, create a LinearGradientBrush object and set its StartPoint to (0,0) and its EndPoint to (1,0). Then, add two or more GradientStop objects to the LinearGradientBrush.GradientStops collection, that specify the colors in the gradient and their positions.", "To create a vertical linear gradient, create a LinearGradientBrush object and set its StartPoint to (0,0) and its EndPoint to (0,1). Then, add two or more GradientStop objects to the LinearGradientBrush.GradientStops collection, that specify the colors in the gradient and their positions." };

    public int clicks = 0;

    public int num;

    public string[] img = new string[3];


    public LGB()
    {
        InitializeComponent();

        img[0] = "lgb_img.png";
        img[1] = "hlg.png";
        img[2] = "vlg.png";
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        IMage1.Source = img[0];

        UpdateQ();

        Questions questions = new Questions();

        questions.QuestionsChange(0, headText, mainText, img, First_Text, Second_Text, IMage1, 4);
        questions.CheckTheme(num);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        UserInterfaceData u = new UserInterfaceData();

        if (clicks >= headText.Length - 1)
        {
            u.SaveData("lgb", "True");
        }
        else
        {
            u.SaveData("lgb", "False");
        }
    }

    private async void NextBtn_Clicked(object sender, EventArgs e)
    {
        clicks++;

        if (clicks <= 0)
        {
            clicks = 0;
        }
        else if (clicks >= headText.Length + 1)
        {
            await Navigation.PopAsync();
        }

        progressBar.Progress += 0.25;

        UpdateQ();

        Questions questions = new Questions();

        questions.QuestionsChange(clicks, headText, mainText, img, First_Text, Second_Text, IMage1, headText.Length);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        clicks--;

        if (clicks <= 0)
        {
            clicks = 0;
        }

        progressBar.Progress -= 0.25;

        UpdateQ();

        Questions questions = new Questions();

        questions.QuestionsChange(clicks, headText, mainText, img, First_Text, Second_Text, IMage1, headText.Length);
    }

    private void UpdateQ()
    {
        question.Text = clicks.ToString() + " / " + headText.Length.ToString() + " Questions";
    }
}