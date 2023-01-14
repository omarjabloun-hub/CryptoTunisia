using CoinpaprikaAPI.Entity;
using CoinpaprikaAPI.Models;
using CryptoTunisia.MVC.Models;
using CryptoTunisia.MVC.Services;

namespace CryptoTunisia.MVC.API;

public class CoinsClient : ICoinsClient
{
    private CoinpaprikaAPI.Client _client;

    public CoinsClient()
    {
        _client = APIClient.GetClient();
    }

    public async Task<List<Coin>> GetAll()
    {

        var coinsInfo = await _client.GetCoinsAsync();

        List<Coin> top10Coins = new List<Coin>(new Coin[10]);
        if (coinsInfo.Value== null)
        {
            return top10Coins;
        }
        for (int i = 0; i < 10; i++)
        {
            top10Coins[i] = GetCoinById(coinsInfo.Value[i].Id).Result;
        }
        return top10Coins;
    }

    public async Task<Coin> GetCoinById(string id)
    {
        var coinDetails = await _client.GetCoinByIdAsync(id);
        var coinMarketInfo = await _client.GetLatestOhlcForCoinAsync(id, "USD");

        var coin = new Coin(coinDetails.Value.Name,
            (double)coinMarketInfo.Value[0].Close,
            coinMarketInfo.Value[0].MarketCap,
            coinMarketInfo.Value[0].Volume,
            (double)(coinMarketInfo.Value[0].Close * 100 / coinMarketInfo.Value[0].Open));

        return coin;
    }
}
