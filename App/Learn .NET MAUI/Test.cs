using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_.NET_MAUI;

internal class Test
{
    public async void SetQuestions(int num, string[] question, Label label)
    {

        try
        {
			if (num < question.Length - 1)
			{
				label.Text = question[num + 1];
			}

			if (num == question.Length - 1)
			{
				int score = Convert.ToInt16(await SecureStorage.GetAsync("UITestScore"));

				string[] ends = { "Keep going you are doing well!", "Great work but don't forget the other tests!" };

				Console.WriteLine(score);

				if (score >= 0.5)
				{
					Random r = new Random();

					label.Text = ends[r.Next(ends.Length)];
				}
				else if (score < 0.5)
				{
					label.Text = "You can do better so for now this test will not be complete for you!";
				}
			}
		} catch { }

    }

    public void SetAnswers(int num, string[] ans1, string[] ans2, string[] ans3, Label answer1, Label answer2, Label answer3)
    {
        if (num < ans1.Length - 1)
        {
            try
            {
                answer1.Text = ans1[num + 1];
                answer2.Text = ans2[num + 1];
                answer3.Text = ans3[num + 1];
            }
            catch
            {

            }
        }

        if (num == ans1.Length - 1)
        {
			answer1.Text = "";
			answer2.Text = "";
			answer3.Text = "";
		}
    }
}
