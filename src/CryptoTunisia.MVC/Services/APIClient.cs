using CoinpaprikaAPI;

namespace CryptoTunisia.MVC.Services;

public class APIClient
{
    private static CoinpaprikaAPI.Client _client;
    private APIClient()
    {
    }

    public static CoinpaprikaAPI.Client GetClient()
    {
        if (_client == null)
        {
            _client = new CoinpaprikaAPI.Client();
        }
        return _client;
    }
}
