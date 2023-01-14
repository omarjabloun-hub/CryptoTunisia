using System.ComponentModel.DataAnnotations;
using EntityFrameworkCore.BootKit;

namespace CryptoTunisia.MVC.Models;

public class User
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(50)]
    public string UserName { get; set; }
    public string Password { get; set; }
    
    [Required]
    [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$" , ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }
    

  //  [HasNoKey]
  //  public List<int>? FollowedCoins { get; set; }
}