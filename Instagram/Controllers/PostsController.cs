using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Instagram.Controllers
{
    public class PostsController : Controller
    {
        [HttpPost]
        public void uploadPost(IFormFile[] file , string desc)
        {
            return View();
        }
    }
}
