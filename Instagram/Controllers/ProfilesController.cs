using Instagram.Areas.Identity.Data;
using Instagram.Classes;
using Instagram.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Controllers
{
    public class ProfilesController : Controller
    {
        private readonly IWebHostEnvironment host;
        private readonly UserManager<InstagramUser> manager;
        private readonly InstagramContext Db;
        CBase cb;
        public ProfilesController(IWebHostEnvironment _host, UserManager<InstagramUser> _manager, InstagramContext _Db)
        {
            host = _host;
            manager = _manager;
            Db = _Db;
            cb = new CBase(_host, _manager, _Db);
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Profile(string Name , string Bio , IFormFile Photos)
        {
            cb.SaveImage(Photos);
            var u = cb.GetInstagramUser(User);
            u.Name = Name;
            u.Bio = Bio;
            u.Photo = Photos.FileName;
            cb.saveUser(u);
            return View();
        }

        [Authorize]
        public IActionResult MyProfile()
        {
            return View(cb.GetInstagramUser(User));
        }

    }
}
