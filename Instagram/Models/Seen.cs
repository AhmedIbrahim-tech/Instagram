using Instagram.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Models
{
    public class Seen
    {
        public int ID { get; set; }
        public string StoryID { get; set; }
        public int UserID { get; set; }

        public virtual Story Story { get; set; }
        public virtual InstagramUser User { get; set; }

    }
}
