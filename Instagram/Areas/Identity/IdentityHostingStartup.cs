using System;
using Instagram.Areas.Identity.Data;
using Instagram.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Instagram.Areas.Identity.IdentityHostingStartup))]
namespace Instagram.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<InstagramContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("InstagramContextConnection")));

                services.AddDefaultIdentity<InstagramUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<InstagramContext>();
            });
        }
    }
}