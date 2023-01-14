using CoinpaprikaAPI;
using CryptoTunisia.MVC.API;
using CryptoTunisia.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CryptoTunisia.MVC.Controllers;

public class CoinsController : Controller
{
    // GET
    public IActionResult Index()
    {
        // var coinsClient = new CoinsClient();
        // var coins = coinsClient.GetAll();
        var client = new CoinsClient();
        try
        {
            var coins = client.GetAll().Result;
            ViewBag.coins = coins;
            return View();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
