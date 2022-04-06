﻿namespace Microsoft.Maui.Controls
{
	public partial class WebView
	{
		public static IPropertyMapper<IWebView, WebViewHandler> ControlsWebViewMapper = new PropertyMapper<WebView, WebViewHandler>(WebViewHandler.Mapper)
		{
#if WINDOWS
			[nameof(PlatformConfiguration.WindowsSpecific.WebView.IsJavaScriptAlertEnabledProperty.PropertyName)] = MapIsJavaScriptAlertEnabled,
#endif
		};

		internal static new void RemapForControls()
		{
			// Adjust the mappings to preserve Controls.WebView legacy behaviors
			WebViewHandler.Mapper = ControlsWebViewMapper;
		}
	}
}