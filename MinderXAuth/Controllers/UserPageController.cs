using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MinderXAuth.Models;
using MinderXAuth.ViewModels;

namespace MinderXAuth.Controllers
{
    public class UserPageController : Controller
    {
        MinderXAContext db;

        public UserPageController(MinderXAContext context)
        {
            this.db = context;
        }

        public IActionResult UserPage(int id)
        {
            UserPageModel userPageModel = new UserPageModel();

            bool myFriend = false;

            var friend = db.Friends.Where(c => c.USerOneId == Convert.ToInt32(User.Identity.Name) && c.USerTwoId == id).FirstOrDefault();
            if (friend != null)
            {
                userPageModel.myFriend = true;
            }
            else
            {
                userPageModel.myFriend = false;
            }

            User UserPage = db.Users.Where(c => c.UserId == id).FirstOrDefault();
            ViewData["user"] = UserPage;

            userPageModel.userPage = UserPage;

            List<MindModel> mindModel = new List<MindModel>();

            foreach (var myMind in db.Minds)
            {
                if (UserPage.UserId == myMind.UserId)
                {
                    MindModel m = new MindModel();
                    m.UserId = myMind.UserId;
                    m.MindMess = myMind.MindMess;
                    m.NumOfLikes = myMind.NumOfLikes;
                    m.DateOfMind = myMind.DateOfMind;
                    m.MindId = myMind.MindId;
                    m.UserPic = UserPage.ProfilePic;

                    m.Comments2 = new Dictionary<Comment, String>();

                    foreach (var comm in db.Comments)
                    {
                        if (comm.MindId == m.MindId)
                        {
                            User commenter = db.Users
                                .Where(c => c.UserId == comm.UserId)
                                .FirstOrDefault();

                            m.Comments2.Add(comm, commenter.ProfilePic);
                        }
                    }

                    var like = db.Likes.Where(c => c.MindId == myMind.MindId && /*UserPage.UserId*/Convert.ToInt32(User.Identity.Name) == c.UserId).FirstOrDefault();
                    if (like != null)
                    {
                        m.liked = true;
                    }
                    else
                    {
                        m.liked = false;
                    }


                    mindModel.Add(m);
                }
            }

            userPageModel.userPageMinds = mindModel.ToList();

            return View(userPageModel);
          
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> AddToFriend(int friendId)
        {

            Friend fr = new Friend() { USerOneId = Convert.ToInt32(User.Identity.Name), USerTwoId = friendId };

            db.Friends.Add(fr);
            await db.SaveChangesAsync();

            String redirectPatg = "~/UserPage/UserPage?id=" + friendId.ToString();

            return RedirectPermanent(redirectPatg);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> removeFromFriend(int friendId)
        {

            Friend fr = db.Friends
                .Where(c => c.USerOneId == Convert.ToInt32(User.Identity.Name) && c.USerTwoId == friendId)
                .FirstOrDefault();

            db.Friends.Remove(fr);
            await db.SaveChangesAsync();

            String redirectPatg = "~/UserPage/UserPage?id=" + friendId.ToString();

            return RedirectPermanent(redirectPatg);

        }
    }
}