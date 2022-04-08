﻿using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using UIKit;

namespace Microsoft.Maui.Controls.Platform
{
	public static class NavigationPageExtensions
	{
		public static void UpdatePrefersLargeTitles(this UINavigationController platformView, NavigationPage navigationPage)
		{
			if (platformView.NavigationBar == null)
				return;

			platformView.NavigationBar.PrefersLargeTitles = navigationPage.OnThisPlatform().PrefersLargeTitles();
		}

		public static void UpdateIsNavigationBarTranslucent(this UINavigationController platformView, NavigationPage navigationPage)
		{
			if (platformView.NavigationBar == null)
				return;

			platformView.NavigationBar.Translucent = navigationPage.OnThisPlatform().IsNavigationBarTranslucent();
		}
	}
}