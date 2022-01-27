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
using System.IO;
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
        private object hosting;

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
        public IActionResult CreateProfile()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProfile(string name, string Bio, IFormFile Photos)
        {
            var user = cb.GetInstagramUser(User);
            user.Name = name;
            user.Bio = Bio;
            user.Photo = Photos.FileName;
            cb.SaveImage(Photos);
            cb.saveUser(user);
            return View();
        }


        [Authorize]
        public IActionResult MyPageProfile()
        {
            return View(cb.GetInstagramUser(User));
        }

        [HttpPost]
        public IActionResult EditProfile(string name, string Bio)
        {
            var user = cb.GetInstagramUser(User);
            user.Name = name;
            user.Bio = Bio;

            cb.saveUser(user);
            return RedirectToAction("MyPageProfile");
        }

        [HttpPost]

        public async Task<bool> ChangePassword(string OldPassword, string NewPassword)
        {
            var user = cb.GetInstagramUser(User);
            var Result = await manager.ChangePasswordAsync(user, OldPassword, NewPassword);
            return Result.Succeeded;
        }

    }
}
