using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Models
{
    public class Chat
    {
        public int ID { get; set; }
        public string FirstID { get; set; }
        public string SecondID { get; set; }
        public DateTime LastDate { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
