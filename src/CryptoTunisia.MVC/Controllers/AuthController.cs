using Microsoft.AspNetCore.Mvc;

namespace CryptoTunisia.MVC.Controllers;

public class AuthController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    // Login
    public IActionResult Login()
    {

    return View();
    }

    // Register
    public IActionResult Register()
    {
        return View();
    }

    // Logout
    public IActionResult Logout()
    {
        return View();
    }
}
