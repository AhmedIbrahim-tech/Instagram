using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Models
{
    public class Follow
    {
        public int ID { get; set; }
        public string FollowerID { get; set; }
        public string FollowingID { get; set; }
    }
}
