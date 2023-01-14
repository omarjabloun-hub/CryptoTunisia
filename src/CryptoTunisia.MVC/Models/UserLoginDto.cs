using System.ComponentModel.DataAnnotations;

namespace CryptoTunisia.MVC.Models;

public class UserLoginDto
{
    [Required]
    [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$" , ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }
    public string Password { get; set; }
}