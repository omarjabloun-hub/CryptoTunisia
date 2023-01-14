using Microsoft.AspNetCore.Mvc;

namespace CryptoTunisia.MVC.Controllers;

public class ProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}