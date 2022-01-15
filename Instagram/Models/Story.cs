using Instagram.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Models
{
    public class Story
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Photo { get; set; }
        public string Desc { get; set; }
        public string UserID { get; set; }
        public int SeenCount { get; set; }

        public virtual InstagramUser User { get; set; }
    }
}
