using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MinderXAuth.Models;

namespace MinderXAuth.Controllers
{
    public class SettingsController : Controller
    {
        MinderXAContext db;

        public SettingsController(MinderXAContext context)
        {
            this.db = context;
        }

        [Authorize]
        public IActionResult Settings()
        {
            User user = db.Users
                .Where(c => c.UserId == Convert.ToInt32(User.Identity.Name))
                .FirstOrDefault();

            return View(user);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Change(String UserLogin, String Email, String UserPassword, String ProfilePic)
        {
            User user = db.Users
                .Where(c => c.UserId == Convert.ToInt32(User.Identity.Name))
                .FirstOrDefault();

            user.UserLogin = UserLogin;
            user.Email = Email;
            user.ProfilePic = ProfilePic;
            user.UserPassword = UserPassword;

            await db.SaveChangesAsync();

            return View("Settings", user);
        }
    }
}