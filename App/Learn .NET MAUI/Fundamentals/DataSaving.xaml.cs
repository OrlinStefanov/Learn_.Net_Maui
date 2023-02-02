namespace Learn_.NET_MAUI.Fundamentals;

public partial class DataSaving : ContentPage
{
	public string[] headText = { "Securety storage", "Light and Dark mode", "File picker" };

	public string[] mainText = { "To save a value to SecureStorage we use wait SecureStorage.SetAsync(name, value); \r\n\r\n To read value from SecureStorage we use wait SecureStorage.GetAsync(name); \r\n\r\n To remove value we use await SecureStorage we use await SecureStorage.Remove(name)",
								 "Light mode is acive by default but if you want to active the Dark mode you have to type: Application.Current.UserAppTheme = AppTheme.Dark;. \r\n\r\n Ogf course to access the Light mode again we use: Application.Current.UserAppTheme = AppTheme.Light;.",
								 "The PickAsync method prompts the user to pick a file from the device. Use the PickOptions type to specify the title and file types allowed with the picker. \r\n\r\n If you want the user to pick multiple files, call the FilePicker.PickMultipleAsync method. This method also takes a PickOptions parameter to specify additional information. The results are the same as PickAsync, but instead of the FileResult type returned, an IEnumerable<FileResult> type is returned with all of the selected files."};

	public int clicks = 0;

	public int num;

	public string[] img = new string[6];

	public DataSaving()
	{
		InitializeComponent();

		img[0] = "securestorage_fun.png";
		img[1] = "ldmode_fun.png";
		img[2] = "filepicker_fun.png";
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		IMage1.Source = img[0];

		UpdateQ();

		Questions questions = new Questions();

		questions.QuestionsChange(0, headText, mainText, img, First_Text, Second_Text, IMage1, headText.Length);
		questions.CheckTheme(num);
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

		UpdateQ();

		progressBar.Progress += 0.33;

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

		UpdateQ();

		progressBar.Progress -= 0.33;

		Questions questions = new Questions();

		questions.QuestionsChange(clicks, headText, mainText, img, First_Text, Second_Text, IMage1, headText.Length);
	}

	private void UpdateQ()
	{
		question.Text = clicks.ToString() + " / " + headText.Length.ToString() + " Questions";
	}
}