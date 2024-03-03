namespace CryptoApp.Views
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtcButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Best cryptocurency!", "It is a Bitcoin", "Do you agree?");
        }
    }

}
