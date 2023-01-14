namespace CryptoTunisia.MVC.Models;



public class Coin : ICoin
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public string Slug { get; set; }
    public int Rank { get; set; }
    public double Price { get; set; }
    public double Volume24H { get; set; }
    public double MarketCap { get; set; }
    public double AvailableSupply { get; set; }
    public double TotalSupply { get; set; }
    public double MaxSupply { get; set; }
    public DateTime LastUpdated { get; set; }
    public double PercentChange1H { get; set; }
    public double PercentChange24H { get; set; }
    public double PercentChange7D { get; set; }
}
public interface ICoin
{
    // Crypto Coin
    string Name { get; set; }
    string Symbol { get; set; }
    string Slug { get; set; }
    int Rank { get; set; }
    double Price { get; set; }
    double Volume24H { get; set; }
    double MarketCap { get; set; }
    double AvailableSupply { get; set; }
    double TotalSupply { get; set; }
    double MaxSupply { get; set; }
    DateTime LastUpdated { get; set; }
    double PercentChange1H { get; set; }
    double PercentChange24H { get; set; }
    double PercentChange7D { get; set; }
}