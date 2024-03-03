using CryptoApp.Services;

namespace CryptoApp.Views;

public partial class Ethereum : ContentPage
{
    private readonly ICryptoPriceService cryptoPriceService;

    public Ethereum(ICryptoPriceService cryptoPriceService)
    {
        InitializeComponent();
        this.cryptoPriceService = cryptoPriceService;

        LoadCryptoData();
    }

    private async void LoadCryptoData()
    {
        Price.Text = await cryptoPriceService
            .GetPriceAsync(Enums.CryptoCurrency.ETH);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        LoadCryptoData();
    }
}