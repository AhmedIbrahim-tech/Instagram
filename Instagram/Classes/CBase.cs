using Instagram.Areas.Identity.Data;
using Instagram.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Instagram.Classes
{
    public class CBase
    {
        private readonly IWebHostEnvironment host;
        private readonly UserManager<InstagramUser> manager;
        private readonly InstagramContext Db;

        public CBase( IWebHostEnvironment _host , UserManager<InstagramUser> _manager , InstagramContext _Db)
        {
            host = _host;
            manager = _manager;
            Db = _Db;
        }

        public void SaveImage(IFormFile file)
        {
            if (file != null)
            {
                if (file.FileName.IndexOf(".jpg") > 0 || file.FileName.IndexOf(".jpeg") > 0 || file.FileName.IndexOf(".png") > 0 )
                {
                    string path = Path.Combine(host.WebRootPath, "Uploads", file.FileName);
                    file.CopyTo(new FileStream(path, FileMode.Create));
                }
            }
        }

        public InstagramUser GetInstagramUser(ClaimsPrincipal user)
        {
            return Db.Users.Find(manager.GetUserId(user));
        }

        public void saveUser(InstagramUser user)
        {
            Db.Users.Update(user);
            Db.SaveChanges();
        }


    }
}
