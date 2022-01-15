using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string SenderID { get; set; }
        public int ChatID { get; set; }
        public string Content { get; set; }
        public virtual Chat Chat { get; set; }

    }
}
