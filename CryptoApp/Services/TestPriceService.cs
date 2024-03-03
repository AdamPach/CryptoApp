using CryptoApp.Enums;

namespace CryptoApp.Services;

public class TestPriceService : ICryptoPriceService
{
    private int _requests = 0;

    Task<string> ICryptoPriceService.GetPriceAsync(CryptoCurrency currency)
    {
        int price = currency switch
        {
            CryptoCurrency.BTC => 60000,
            CryptoCurrency.ETH => 3300,
            _ => throw new NotImplementedException(),
        };

        _requests++;

        price = price + (_requests * 42);

        return Task.FromResult(price.ToString());
    }
}
