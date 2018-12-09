using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using MinderXAuth.Models;
using MinderXAuth.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MinderXAuth.Controllers
{
    public class AccountController : Controller
    {
        private MinderXAContext db;

        public AccountController(MinderXAContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u =>  u.UserPassword == model.Password && (u.Email == model.Email || u.UserLogin == model.Email));
                if (user != null)
                {
                    await Authenticate(user.UserId.ToString());

                    foreach(var userIn in db.Users)
                    {
                        if (user.UserId == userIn.UserId) {

                            ViewData["mainUser"] = userIn;
                        }
                    }

                    return RedirectToAction("Lenta", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        //////////
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user == null)
                {

                    db.Users.Add(new User { Email = model.Email, UserPassword = model.Password, UserLogin =model.Login, ProfilePic = "http://chittagongit.com//images/default-user-icon/default-user-icon-9.jpg" });
                    await db.SaveChangesAsync();

                    await Authenticate(model.Email); 
                    //await Authenticate(Convert.ToString(user.UserId));

                    return RedirectToAction("Login", "Account");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
 
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}