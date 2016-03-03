using System;
using Xamarin.Forms;

namespace Actividad3
{
	public class ButtonLoggerPage : ContentPage
	{
		StackLayout loggerLayout = new StackLayout();

		public ButtonLoggerPage()
		{
			// Create the Button and attach Clicked handler.
			Button button = new Button
			{
				Text = "Haga click aquí" 
			};
			button.Clicked += OnButtonClicked;

			this.Padding = new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);

			this.Content = new StackLayout
			{
				Children =
				{
					button,
					new ScrollView
					{
						VerticalOptions = LayoutOptions.FillAndExpand,
						Content = loggerLayout
					}
				}
				};
		}

		void OnButtonClicked(object sender, EventArgs args)
		{

			loggerLayout.Children.Add(new Label
				{
					Text = "Abrahán Cortés Hernández " + DateTime.Now.ToString("T")
				});
		}
	}
}

