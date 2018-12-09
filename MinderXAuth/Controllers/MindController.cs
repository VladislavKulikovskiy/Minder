using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MinderXAuth.Models;

namespace MinderXAuth.Controllers
{
    public class MindController : Controller
    {


        MinderXAContext db;

        public MindController(MinderXAContext context)
        {
            this.db = context;
        }


        [HttpGet]
        [Authorize]
        public IActionResult CreateMind()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateMind(Mind m)
        {


            DateTime now = DateTime.Now;

            db.Minds.Add(new Mind { UserId = Convert.ToInt32(User.Identity.Name), MindMess = m.MindMess,  DateOfMind = now, NumOfLikes = 0});
            await db.SaveChangesAsync();

            return RedirectToAction("Lenta", "Home");
        }
    }
}