namespace CryptoTunisia.MVC.Models;

public class Coin : ICoin
{
    public Coin(string name, double price, double marketCap, double volume,
        double percentChange24H)
    {
        Name = name;
        Price = price;
        MarketCap = marketCap;
        Volume = volume;
        PercentChange24H = percentChange24H;
    }

    public string Name { get; set; }
    public double Price { get; set; }
    public double MarketCap { get; set; }
    public double Volume { get; set; }
    public double PercentChange24H { get; set; }
}

public interface ICoin
{
    string Name { get; set; }
    double Price { get; set; }
    double MarketCap { get; set; }
    double Volume { get; set; }
    double PercentChange24H { get; set; }
}
