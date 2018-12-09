using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MinderXAuth.Models;
using MinderXAuth.ViewModels;

namespace MinderXAuth.Controllers
{
    public class HomeController : Controller
    {
        MinderXAContext db;

        public HomeController(MinderXAContext context)
        {
            this.db = context;

        }

        [Authorize]
        public IActionResult Index()
        {

            List<MindModel> mindModel = new List<MindModel>();

            var user = db.Users
                .Where(c => c.UserId == Convert.ToInt32(User.Identity.Name))
                .FirstOrDefault();

            ViewData["image"] = user.ProfilePic;
            ViewData["user"] = user;

            foreach (var thisMind in db.Minds)
            {
                MindModel m = new MindModel();
                m.UserId = thisMind.UserId;
                m.MindMess = thisMind.MindMess;
                m.NumOfLikes = thisMind.NumOfLikes;
                m.DateOfMind = thisMind.DateOfMind;
                m.MindId = thisMind.MindId;

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

                var like = db.Likes.Where(c => c.MindId == thisMind.MindId && user.UserId == c.UserId).FirstOrDefault();
                if (like != null)
                {
                    m.liked = true;
                }
                else
                {
                    m.liked = false;
                }

                var thisUser = db.Users
              .Where(c => c.UserId == thisMind.UserId)
              .FirstOrDefault();

                m.UserPic = thisUser.ProfilePic;

                mindModel.Add(m);
            }

            mindModel = mindModel.OrderByDescending(x => x.DateOfMind).ToList();

            return View("Lenta", mindModel.ToList());
            //return RedirectPermanent("~/Home/Lenta", mindModel.ToList());
        }

        [Authorize]
        public IActionResult Lenta()
        {
            List<int> friendsIds = new List<int>();
            List<User> friends = new List<User>();
            List<Mind> userMinds = new List<Mind>();
            List<MindModel> mindModel = new List<MindModel>();




            var user = db.Users
                .Where(c => c.UserId == Convert.ToInt32(User.Identity.Name))
                .FirstOrDefault();

            ViewData["image"] = user.ProfilePic;
            ViewData["user"] = user;

            foreach (var fri in db.Friends)
            {
                if (User.Identity.Name == fri.USerOneId.ToString())
                {
                    friendsIds.Add(fri.USerTwoId);
                }
            }

            friendsIds.Add(Convert.ToInt32(User.Identity.Name));

            foreach (var id in friendsIds)
            {
                foreach (var userr in db.Users)
                {
                    if (id == userr.UserId)
                    {
                        friends.Add(userr);
                    }
                }
            }

            foreach (var frien in friends)
            {
                foreach (var myMind in db.Minds)
                {
                    if (frien.UserId == myMind.UserId)
                    {
                        MindModel m = new MindModel();
                        m.UserId = myMind.UserId;
                        m.MindMess = myMind.MindMess;
                        m.NumOfLikes = myMind.NumOfLikes;
                        m.DateOfMind = myMind.DateOfMind;
                        m.MindId = myMind.MindId;
                        m.UserPic = frien.ProfilePic;

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

                        var like = db.Likes.Where(c => c.MindId == myMind.MindId && user.UserId == c.UserId).FirstOrDefault();
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
            }

            mindModel = mindModel.OrderByDescending(x => x.DateOfMind).ToList();


            return View(mindModel.ToList());
        }


        [HttpPost]
        [Authorize]
        public async Task<ActionResult> addLike(int MindId)
        {
            Like like = db.Likes
             .Where(c => c.UserId == Convert.ToInt32(User.Identity.Name) && c.MindId == MindId)
             .FirstOrDefault();



            if (like == null)
            {
                Like like2 = new Like { UserId = Convert.ToInt32(User.Identity.Name), MindId = MindId };

                var thisMind = db.Minds
                    .Where(c => c.MindId == MindId)
                    .FirstOrDefault();

                thisMind.NumOfLikes += 1;

                db.Likes.Add(like2);
                await db.SaveChangesAsync();

                MindModel thisMindModel = new MindModel();
                thisMindModel.liked = true;
                thisMindModel.MindId = thisMind.MindId;
                thisMindModel.NumOfLikes = thisMind.NumOfLikes;

                //return PartialView(thisMind);
                return PartialView(thisMindModel);
            }

            else
            {
                var thisMind = db.Minds
              .Where(c => c.MindId == MindId)
              .FirstOrDefault();

                thisMind.NumOfLikes -= 1;

                db.Likes.Remove(like);
                await db.SaveChangesAsync();

                MindModel thisMindModel = new MindModel();
                thisMindModel.liked = false;
                thisMindModel.MindId = thisMind.MindId;
                thisMindModel.NumOfLikes = thisMind.NumOfLikes;

                return PartialView("addLike", thisMindModel);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> removeLike(int MindId)
        {
            Like like = db.Likes
                .Where(c => c.UserId == Convert.ToInt32(User.Identity.Name) && c.MindId == MindId)
                .FirstOrDefault();

            var thisMind = db.Minds
                .Where(c => c.MindId == MindId)
                .FirstOrDefault();

            thisMind.NumOfLikes -= 1;

            db.Likes.Remove(like);
            await db.SaveChangesAsync();

            return PartialView("addLike", thisMind);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> add(int MindId)
        {
            int k = MindId++;
            return View("TEST2", k);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> addComment(String commentText, int MindId)
        {

            var user = db.Users
          .Where(c => c.UserId == Convert.ToInt32(User.Identity.Name))
          .FirstOrDefault();


            MindModel m = new MindModel();

            if (commentText != null || commentText != "")
            {
                Comment com = new Comment() { CommentMess = commentText, MindId = MindId, UserId = Convert.ToInt32(User.Identity.Name), DateOfComment = DateTime.Now};
                db.Comments.Add(com);
                await db.SaveChangesAsync();


                m.Comments2 = new Dictionary<Comment, String>();
                m.UserPic = user.ProfilePic;
                m.MindId = MindId;
                foreach (var comm in db.Comments)
                {
                    if (comm.MindId == MindId)
                    {
                        User commenter = db.Users
                            .Where(c => c.UserId == comm.UserId)
                            .FirstOrDefault();

                        m.Comments2.Add(comm, commenter.ProfilePic);
                    }
                }

               
            }

            return PartialView("_Comments", m);
        }



        private List<T> newList<T>()
        {
            throw new NotImplementedException();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
