using CoinpaprikaAPI.Entity;
using CoinpaprikaAPI.Models;
using CryptoTunisia.MVC.Models;

namespace CryptoTunisia.MVC.API;

public interface ICoinsClient
{
    Task<List<Coin>> GetAll();
    Task<Coin> GetCoinById(string id);
}
