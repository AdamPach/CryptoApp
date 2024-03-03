namespace CryptoApp.Views;

public partial class Currencies : ContentPage
{
	public Currencies()
	{
		InitializeComponent();
	}

    private async void EthereumClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Ethereum));
    }

    private async void BitcoinClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Bitcoin));
    }
}