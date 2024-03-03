using CryptoApp.Enums;

namespace CryptoApp.Services;

public interface ICryptoPriceService
{
    public Task<string> GetPriceAsync(CryptoCurrency currency);
}
