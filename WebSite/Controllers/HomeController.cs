using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bertoni.Proxies;
using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var proxy = new AlbumProxy())
            {
                ViewData["albums"] = await proxy.GetAsync();
            }
            return View();
        }

        public async Task<IActionResult> Photos(int albumId)
        {
            using(var proxy = new PhotoProxy())
            {
                ViewData["photos"] = await proxy.GetAsync(albumId);
            }
            return PartialView();
        }

        public async Task<IActionResult> Comments(int photoId)
        {
            using (var proxy = new CommentProxy())
            {
                ViewData["comments"] = await proxy.GetAsync(photoId);
            }
            return PartialView();
        }
    }
}
