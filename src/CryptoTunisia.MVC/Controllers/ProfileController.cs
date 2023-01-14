using CryptoTunisia.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CryptoTunisia.MVC.Controllers;

public class ProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        var user = new User(
            1,
            "Habib Sellami",
            "0000",
            "habib@mail.tn");
        return View(user);
    }

    [HttpGet("profile/edit")]
    public IActionResult Edit()
    {
        var user = new User(
            1,
            "Habib Sellami",
            "0000",
            "habib@mail.tn");
        return View(user);
    }
    [HttpPost("profile/edit")]
    public IActionResult Edit(User user)
    {
        //Edit user

        return RedirectToAction("Index");
    }
}
