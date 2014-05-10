using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioSite.Controllers
{
    public class ProjectsController : Controller
    {
        //
        // GET: /Projects/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PhotoCollage()
        {
            String desktopImagePath = @"/Images/PhotoCollage/desktop",
                   mobileImagePath = @"/Images/PhotoCollage/mobile";
            var desktopGallery = new List<String>()
            {
                "/gallery1.png",
                "/gallery2.png",
                "/gallery3.png",
                "/gallery4.png",
                "/gallery5.png",
                "/gallery6.png",
                "/gallery7.png"
            };
            var mobileGallery = new List<String>()
            {
                "/gallery1.png",
                "/gallery2.png",
                "/gallery3.png",
                "/gallery4.png",
                "/gallery5.png",
                "/gallery6.png",
                "/gallery7.png"
            };
            ViewBag.DesktopImagePath = desktopImagePath;
            ViewBag.DesktopGallery = desktopGallery;
            ViewBag.MobileImagePath = mobileImagePath;
            ViewBag.MobileGallery = mobileGallery;
            return View();
        }

        public ActionResult Math115A()
        {
            return View();
        }

        public ActionResult Math115B()
        {
            return View();
        }

        public ActionResult Math125A()
        {
            return View();
        }

        public ActionResult Math135A()
        {
            return View();
        }

        public ActionResult Math135B()
        {
            return View();
        }
        
        public ActionResult PeopleSearch()
        {
            String desktopImagePath = @"/Images/PeopleSearch/desktop",
                   mobileImagePath = @"/Images/PeopleSearch/mobile";
            var desktopGallery = new List<String>()
            {
                "/gallery1.png",
                "/gallery2.png",
                "/gallery3.png",
                "/gallery4.png",
                "/gallery5.png",
                "/gallery6.png",
                "/gallery7.png",
                "/gallery8.png"
            };
            var mobileGallery = new List<String>();
            ViewBag.DesktopImagePath = desktopImagePath;
            ViewBag.DesktopGallery = desktopGallery;
            ViewBag.MobileImagePath = mobileImagePath;
            ViewBag.MobileGallery = mobileGallery;
            return View();
        }

        public ActionResult SchoolFeedSettings()
        {
            ViewBag.ImagePath = @"/Images/SchoolFeedSettings";
            ViewBag.Gallery = new List<String>()
            {
                "/gallery1.png",
                "/gallery2.png",
                "/gallery3.png"
            };
            return View();
        }
    }
}