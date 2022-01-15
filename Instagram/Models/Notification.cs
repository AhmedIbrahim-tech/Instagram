using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Models
{
    public class Notification
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }
        public string UserID { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Href { get; set; }
        public bool IsChecked { get; set; }
    }
}
