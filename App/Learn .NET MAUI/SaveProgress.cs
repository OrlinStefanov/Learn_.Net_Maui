using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_.NET_MAUI
{
	public class SaveProgress
	{
		public int numLessons;

		public async void LoadUserInterface(ProgressBar p)
		{
			string[] names = { "views2", "views1", "pages", "layouts", "firstSteps" };

			p.Progress = 0;

			for (int i = 0; i < names.Length; i++)
			{
				string sth = await SecureStorage.GetAsync(names[i]);

				if (sth == "True")
				{
					p.Progress += 0.2f;

					numLessons++;
					await SecureStorage.SetAsync("numL", numLessons.ToString());
				}
			}
		}

		public async void LoadBasicC(ProgressBar c)
		{
			string[] names = { "methods", "fs", "events", "elements", "controls", "syntax", "variables" };

			c.Progress = 0;
			
			for (int i = 0; i < names.Length; i ++)
			{
				string sth = await SecureStorage.GetAsync(names[i]);

				if (sth == "True")
				{
					c.Progress += 0.14f;

					numLessons++;
					await SecureStorage.SetAsync("numL", numLessons.ToString());
				}
			}
		}

	}
}
