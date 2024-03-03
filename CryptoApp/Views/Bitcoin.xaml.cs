using CryptoApp.Services;

namespace CryptoApp.Views;

public partial class Bitcoin : ContentPage
{
	private readonly ICryptoPriceService cryptoPriceService;

    public Bitcoin(ICryptoPriceService cryptoPriceService)
    {
        InitializeComponent();
        this.cryptoPriceService = cryptoPriceService;

        LoadCryptoData();
    }

    private async void LoadCryptoData()
    {
        Price.Text = await cryptoPriceService
            .GetPriceAsync(Enums.CryptoCurrency.BTC);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        LoadCryptoData();
    }
}