﻿using System;
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
            };
            var mobileGallery = new List<String>()
            {
                "/gallery1.png",
                "/gallery2.png",
                "/gallery3.png",
                "/gallery4.png",
                "/gallery5.png",
                "/gallery6.png",
            };
            ViewBag.DesktopImagePath = desktopImagePath;
            ViewBag.DesktopGallery = desktopGallery;
            ViewBag.MobileImagePath = mobileImagePath;
            ViewBag.MobileGallery = mobileGallery;
            return View();
        }
	}
}