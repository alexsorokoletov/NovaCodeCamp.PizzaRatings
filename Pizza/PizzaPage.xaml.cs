using Xamarin.Forms;

namespace Pizza
{
	public partial class PizzaPage : ContentPage
	{
		public PizzaPage()
		{
			InitializeComponent();
		}

		void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			ratingLabel.Text = $"Pizza rating: {ratingStepper.Value}";
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var pizzaPlace = place.Text;
			if (string.IsNullOrWhiteSpace(pizzaPlace))
				return;

			var ratingValue = ratingStepper.Value;
			var message = $"Your rating {ratingValue} for {pizzaPlace} accepted!";
			DisplayAlert("Pizza rating", message, "OK");
		}
	}
}
