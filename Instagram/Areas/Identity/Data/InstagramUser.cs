using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Instagram.Models;
using Microsoft.AspNetCore.Identity;

namespace Instagram.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the InstagramUser class
    public class InstagramUser : IdentityUser
    {
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Bio { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Story> Stories { get; set; }
    }
}
