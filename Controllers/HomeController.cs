using System;
using System.Linq;
using CSharp.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CSharp.Controllers
{
    public class HomeController : Controller
    {
        private MyContext DbContext;
        public HomeController(MyContext context)
        {
            DbContext = context;
        }

        // controls for one-page login-registration, password hasher, match, and uniqueness //
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("index");
        }

        [HttpGet("logout")]
        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost("register")]
        public IActionResult Register(Wrapper FromForm)
        {
            if(ModelState.IsValid)
            {
                //Hashing Password//
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                FromForm.UserForm.Password = Hasher.HashPassword(FromForm.UserForm, FromForm.UserForm.Password);
                DbContext.Add(FromForm.UserForm);
                DbContext.SaveChanges();

                // User userInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.Email); 
                HttpContext.Session.SetInt32("UserId", FromForm.UserForm.UserId);

                // Wrapper OneUserId = User userInDb
                return RedirectToAction ("Dashboard");
            }
            else    
            {
                return View("Index"); 
            }
        }

        [HttpPost("login")]
        public IActionResult Login(Wrapper FromForm)
        {
            if(ModelState.IsValid)
            {
                User InDb = DbContext.Users.FirstOrDefault(u => u.Email == FromForm.LoginForm.Email);

                if(InDb == null)
                {
                    ModelState.AddModelError("Login.Email", "Invalid email/password");
                    return Index();
                }

                PasswordHasher<LoginUser> Hasher = new PasswordHasher<LoginUser>();
                PasswordVerificationResult Result = Hasher.VerifyHashedPassword(FromForm.LoginForm, InDb.Password, FromForm.LoginForm.Password);

                if(Result == 0)
                {
                    ModelState.AddModelError("Login.Email", "Invalid email/password");
                    return Index();
                }
                HttpContext.Session.SetInt32("UserId", InDb.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return Index();
            }
        }

        // Create, Read, Update for Ideas and tracking of Likes //
        //every page can only be accessed by a loggedin user (kept in session)//

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
              // get user id from session 
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            // check if user is logged in, if not logged in, redirect to Index
            if (LoggedId == null)
            {
                    return RedirectToAction("Index");
            }

            DashboardWrapper thing = new DashboardWrapper()
                {
                    AllIdeas = DbContext.Ideas
                        .Include(i=> i.Creator)
                        .Include (i => i.UsersWhoLikeThisIdea)
                            .ThenInclude(l=>l.Liker)
                        .ToList(),
                    LoggedUser = DbContext.Users
                        .FirstOrDefault(u =>u.UserId == (int)LoggedId)
                };
                return View("Dashboard", thing);
        }


        [HttpGet("ideas/new")]
        public IActionResult CreateIdea()
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if(LoggedId == null)
            {
                return RedirectToAction("Index");
            }
                return View("NewIdea");
        }   


        [HttpPost("ideas/create")]
        public IActionResult CreateIdea(Idea idea)
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if(LoggedId == null)
            {
                return RedirectToAction("Index");
            }
            //to connect the loggedin user with this specific idea 
            idea.UserId = (int)LoggedId;
            
            if(ModelState.IsValid)
            {
                DbContext.Ideas.Add(idea);
                DbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }   
            else
            {
                return View ("NewIdea");
            }
        }
            
        [HttpGet("oneidea/{IdeaId}")]
        public IActionResult OneIdea(int IdeaId)
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if(LoggedId == null)
            {
                return RedirectToAction("Index");
            }
            DashboardWrapper oneidea = new DashboardWrapper()
            {  //also am converting the sets into lists//
                AllIdeas = DbContext.Ideas
                    // include 1-to-many related model (User) (Cannot  do a theninlcude from this one)
                    .Include(i=>i.Creator)
                    // include many-to-many related model (List<likes>), THENINCLUDE the other end of the relationship 
                    .Include(i=>i.UsersWhoLikeThisIdea)
                    .ThenInclude(l => l.Liker)
                    .ToList(),
                IdeaForm = DbContext.Ideas
                    .FirstOrDefault(i =>i.IdeaId ==(int)IdeaId),
                LoggedUser = DbContext.Users
                    .FirstOrDefault(u =>u.UserId ==(int)LoggedId),
            };
            return View("OneIdea", oneidea);     
        }

        [HttpGet("onecreator/{UserId}")]
        public IActionResult OneCreator(int UserId)
        {
            // int? LoggedId = HttpContext.Session.GetInt32("UserId");
            // if(LoggedId == null)
            // {
            //     return RedirectToAction("Index");
            // }
            DashboardWrapper OneUser = new DashboardWrapper()
            {//going into the DB sets and converting them into lists//
                AllUsers = DbContext.Users
                // include 1-to-many related model (User). Cannot do a "theninlcude" from 1-to-many.
                    .Include(u=>u.CreatedByUser).ToList(),
                AllIdeas = DbContext.Ideas
                    // include many-to-many related model (List<likes>).  Can use the "theninlcude" to reach the other end of the relationship. 
                    .Include(i=>i.UsersWhoLikeThisIdea)
                    .ThenInclude(l => l.Liker)
                    .ToList(),
            };
            return View("OneCreator", UserId);     
        }


        [HttpGet("ideas/{IdeaId}/edit")]
        public IActionResult EditIdea(int IdeaId)
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if(LoggedId == null)
            {
                return RedirectToAction("Index");
            }
            //this is making sure that the Creator of joke is the ONLY ONE editing this idea
            Idea ToEdit = DbContext.Ideas.FirstOrDefault(i => i.IdeaId == IdeaId);
            if(ToEdit == null || ToEdit.IdeaId != (int)LoggedId)
            {
                return RedirectToAction("Dashboard");
            }
            return View("EditIdea", IdeaId);
        }

        [HttpPost("idea/{IdeaId}/update")]
        public IActionResult UpdateIdea(int IdeaId, Idea FromForm)
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if(LoggedId == null)
            {
                return RedirectToAction("Index");
            }
            
            if(ModelState.IsValid)
            {
                FromForm.IdeaId = IdeaId;
                DbContext.Update(FromForm);
                DbContext.Entry(FromForm).Property("CreatedAt").IsModified = false;
                DbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return EditIdea(IdeaId);
        }
        
        [HttpGet("ideas/{IdeaId}/like")]
        public RedirectToActionResult LikeIdea(int IdeaId)
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if(LoggedId == null)
            {
                return RedirectToAction("Index");
            }
            Idea ToJoin = DbContext.Ideas
                .Include(j => j.UsersWhoLikeThisIdea)
                .FirstOrDefault(j => j.IdeaId == IdeaId);

            if(ToJoin == null || ToJoin.UserId == (int)LoggedId || ToJoin.UsersWhoLikeThisIdea.Any(r => r.UserId == (int)LoggedId))
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                Like NewLike = new Like()
                {
                    UserId = (int)LoggedId,
                    IdeaId = IdeaId
                };
                DbContext.Add(NewLike);
                DbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
        }

        [HttpGet("ideas/{IdeaId}/unlike")]
        public RedirectToActionResult Unlike(int IdeaId)
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if(LoggedId == null)
            {
                return RedirectToAction("LogReg");
            }
            Idea ToUnlike = DbContext.Ideas
                .Include(i => i.UsersWhoLikeThisIdea)
                .FirstOrDefault(i => i.IdeaId == IdeaId);

            if(ToUnlike == null || !ToUnlike.UsersWhoLikeThisIdea.Any(r => r.UserId == (int)LoggedId))
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                Like ToRemove = DbContext.Likes.FirstOrDefault(r => r.UserId == (int)LoggedId && r.IdeaId == IdeaId);
                DbContext.Remove(ToRemove);
                DbContext.SaveChanges();

                return RedirectToAction("Dashboard");
            }
        }

        [HttpGet("ideas/{IdeaId}/delete")]
        public RedirectToActionResult DeleteIdea(int IdeaId)
        {
            int? LoggedId = HttpContext.Session.GetInt32("UserId");
            if(LoggedId == null)
            {
                return RedirectToAction("LogReg");
            }
            //this is making sure that the Creator of the idea(or joke) is the ONLY ONE deleting this idea
            Idea ToDelete = DbContext.Ideas.FirstOrDefault(i => i.IdeaId == IdeaId);
            if(ToDelete == null || ToDelete.IdeaId != (int)LoggedId)
        
            {
                return RedirectToAction("Dashboard");
            }

            DbContext.Remove(ToDelete);
            DbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }  

        [HttpPost("idea/like")]
        public RedirectToActionResult LikeIdea(DashboardWrapper FromForm)
        {
            // get user id from session
            int? LoggedId = HttpContext.Session.GetInt32("UserId");

            // check if user is logged in, if not logged in, redirect to Index
            if(LoggedId == null)
            {
                return RedirectToAction("Index");
            }
            // user is logged in , but we need to check if they have already liked this idea previously
            // (Like newLike = FromForm.Form;  could have used this and created that variable)
            // pull out id of idea to join
            int IdeaBeingLikedId = FromForm.LikeForm.IdeaId;

            //to not let a user chose the same idea twice//
            // check if there are ALREADY any existing "Liker Ids (objects) from this loggedid that match the ideaid & like id AND the user id  == the logged user id
            if(DbContext.Likes.Any(e => e.UserId == (int)LoggedId  && e.IdeaId == IdeaBeingLikedId))
                {
                    ModelState.AddModelError("LikeTwice","You sure like this one! You've already clicked like and here, you can only like an idea once.");
                    return RedirectToAction ("Dashboard", FromForm);
                }
    
            // insert logged in user into new "LikeId" object (which is passed in via LikeForm)
                FromForm.LikeForm.UserId = (int)LoggedId;
                DbContext.Likes.Add(FromForm.LikeForm);
                DbContext.SaveChanges();
                
                return RedirectToAction("Dashboard");
        }

        
        [HttpGet("timedisplay")]
        public IActionResult TimeDisplay()
        {
            ViewBag.Date=DateTime.Now.ToString("MMM dd,yyyy");
            ViewBag.Time=DateTime.Now.ToString("h:mm tt");
            return View("TimeDisplay");
        }

        [HttpGet("timetravel")]
        public IActionResult TimeTravel()
        {
            return View("TimeTravel");
        }

        [HttpGet("cat")]
        public IActionResult Cat()
        {
            return View("Cat");
        }
        [HttpGet("pup")]
        public IActionResult Pup()
        {
            return View("Pup");
        }


        [HttpGet("finish")]
        public IActionResult Finish()
        {
            return View("Finish");
        }

        [HttpGet("explore")]
        public IActionResult Explore()
        {
            return View ("Explore");
        }

        [HttpGet("memedefinition")]
        public IActionResult MemeDefinition()
        {
            return View ("MemeDefinition");
        }

        [HttpGet("privacy")]
        public IActionResult Privacy()
        {
            return View ("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

