using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_Project_MVC.Controllers
{
    [Authorize]
    public class BlogsController : Controller
    {
        newdbEntities1 nd = new newdbEntities1();
        // GET: Blogs
        public ActionResult Index()
        {
            var blogdetails = nd.Blog.ToList().OrderByDescending(x=>x.Bid);
            return View(blogdetails);
        }

        public ActionResult Uploadblog()
        {
            return View();
        }
          [HttpPost]
        public ActionResult Uploadblog(Blog bg)
        {
             
            nd.Blog.Add(bg);
            nd.SaveChanges();
            ViewBag.message = "Blogs saved successfully";

            return View();
        }

        public ActionResult Food()
        {
            var foodarticle = nd.Blog.Where(x => x.Bcontent == "Food");
            return View(foodarticle);
        }

        public ActionResult Sports()
        {
            var Sportsarticle = nd.Blog.Where(x => x.Bcontent == "Sports");
            return View(Sportsarticle);
        }

        public ActionResult Movies()
        {
            var Moviesarticle = nd.Blog.Where(x => x.Bcontent == "Movies");
            return View(Moviesarticle);
        }

        public ActionResult Recipeworld()
        {
            
            return View();
        }
    }
}