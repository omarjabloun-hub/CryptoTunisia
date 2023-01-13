namespace CryptoTunisia.MVC.Models;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }
    public int CoinId { get; set; }
    public int UserId { get; set; }
    public virtual Coin? Coin { get; set; }
    public virtual User? User { get; set; }
    
}