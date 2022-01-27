﻿using Microsoft.AspNetCore.Http;

namespace Instagram.ViewModel
{
    public class InstagramUserViewModel
    {
        public string Name { get; set; }
        public string Photo { get; set; }
        public IFormFile File { get; set; }
        public string Bio { get; set; }
    }
}
