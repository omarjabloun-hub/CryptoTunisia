namespace CryptoTunisia.MVC.Models;

public class UserRegisterDto : User 
{
    public string ConfirmPassword { get; set; }
}