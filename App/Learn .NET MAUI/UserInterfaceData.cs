using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_.NET_MAUI
{
	public class UserInterfaceData
	{
		public async void SaveData(string name, string text)
		{
			await SecureStorage.SetAsync(name, text);
		}

		public async void LoadData(string name, ProgressBar progressBar)
		{
			string text = await SecureStorage.GetAsync(name);

			if (text == "True")
			{
				progressBar.Progress = 1;

			} else if (text == "False") 
			{
				progressBar.Progress = 0.5;
			}
		}
	}
}
