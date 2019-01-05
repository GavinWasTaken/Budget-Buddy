using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Budget_Buddy;

namespace UITests_BudgetBuddy
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp.Android.StartApp();
			}

			return ConfigureApp.iOS.StartApp();
		}
	}
}