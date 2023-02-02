namespace Learn_.NET_MAUI.Basic_C_Folder;

public partial class Syntax : ContentPage
{
	public string[] headText = { "Syntax" , "Output", "Input", "Comments", "Math1", "Math2" };
	public string[] mainText = { "Line 1: using System means that we can use classes from the System namespace.\r\n\r\nLine 2: A blank line. C# ignores white space. However, multiple lines makes the code more readable.\r\n\r\nLine 3: namespace is used to organize your code, and it is a container for classes and other namespaces.\r\n\r\nLine 4: The curly braces {} marks the beginning and the end of a block of code.\r\n\r\nLine 5: class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.",
								 "To output values or print text in C#, you can use the WriteLine() method. \r\n\r\n You can add as many WriteLine() methods as you want. Note that it will add a new line for each method. \r\n\r\n You can also output numbers, and perform mathematical calculations \r\n\r\n There is also a Write() method, which is similar to WriteLine().\r\n\r\nThe only difference is that it does not insert a new line at the end of the output.",
								 "You have already learned that Console.WriteLine() is used to output (print) values. Now we will use Console.ReadLine() to get user input.\r\n\r\nIn the following example, the user can input his or hers username, which is stored in the variable userName. Then we print the value of userName. \r\n\r\n The Console.ReadLine() method returns a string. Therefore, you cannot get information from another data type, such as int.",
								 "Single-line comments start with two forward slashes (//).\r\n\r\nAny text between // and the end of the line is ignored by C# (will not be executed). \r\n\r\n Multi-line comments start with /* and ends with */.\r\n\r\nAny text between /* and */ will be ignored by C#.",
								 "The Math.Max(x,y) method can be used to find the highest value of x and y. \r\n\r\n The Math.Min(x,y) method can be used to find the lowest value of of x and y. \r\n\r\n The Math.Sqrt(x) method returns the square root of x.",
								 "The Math.Abs(x) method returns the absolute (positive) value of x. \r\n\r\n Math.Round() rounds a number to the nearest whole number."};
	public int clicks = 0;

	public int num;

	public string[] img = new string[6];

	public Syntax()
	{
		InitializeComponent();

		img[0] = "syntax_basic.png";
		img[1] = "output_basic.png";
		img[2] = "input_basic.png";
		img[3] = "comment_basic.png";
		img[4] = "math1_basic.png";
		img[5] = "math2_basic.png";
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

	protected override void OnDisappearing()
	{
		base.OnDisappearing();

		UserInterfaceData u = new UserInterfaceData();

		if (clicks >= headText.Length - 1)
		{
			u.SaveData("syntax", "True");
		}
		else
		{
			u.SaveData("syntax", "False");
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

		progressBar.Progress += 0.16;

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

		progressBar.Progress -= 0.16;

		UpdateQ();

		Questions questions = new Questions();

		questions.QuestionsChange(clicks, headText, mainText, img, First_Text, Second_Text, IMage1, headText.Length);
	}

	private void UpdateQ()
	{
		question.Text = clicks.ToString() + " / " + headText.Length.ToString() + " Questions";
	}
}