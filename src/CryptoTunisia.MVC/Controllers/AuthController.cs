using CryptoTunisia.MVC.Data.Repository;
using CryptoTunisia.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CryptoTunisia.MVC.Controllers;

public class AuthController : Controller
{
    private readonly IUserRepository _userRepository;
    public AuthController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    // Login 
    [AllowAnonymous]
    [HttpPost]
    public IActionResult Login(UserLoginDto userDto)
    {
        var user = _userRepository.GetUserByEmail(userDto.Email);
        if (user == null)
        {
            return NotFound();
        }
        if (user.Password != userDto.Password)
        {
            return Unauthorized();
        }
        return RedirectToAction(actionName: "Index" 
            , controllerName: "Home");
    }
    
    [AllowAnonymous]
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    // Register
    [AllowAnonymous]
    [HttpPost]
    public IActionResult Register(UserRegisterDto userDto)
    {
        if (userDto.Password != userDto.ConfirmPassword)
        {
            return BadRequest();
        }
        var user = _userRepository.GetUserByUserName(userDto.UserName);
        if (user != null)
        {
            return RedirectToAction("Login");
        }
        _userRepository.Add(new User {
            UserName = userDto.UserName,
            Password = userDto.Password , 
            Email = userDto.Email,
            
        });
        
        return RedirectToAction(actionName: "Index" 
            , controllerName: "Home");
    }

    [AllowAnonymous]
    [HttpGet]
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
