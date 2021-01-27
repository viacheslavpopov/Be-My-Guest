// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;
// using BeMyGuest.Models;

// namespace BeMyGuest
// {
//     public class Startup
//     {
//         public Startup(IHostingEnvironment env)
//         {
//             var builder = new ConfigurationBuilder()
//                 .SetBasePath(env.ContentRootPath)
//                 .AddJsonFile("appsettings.json");
//             Configuration = builder.Build();
//         }

//         public IConfigurationRoot Configuration { get; set; }

//         public void ConfigureServices(IServiceCollection services)
//         {
//             // services.AddMvc();
//             services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

//             services.AddEntityFrameworkMySql()
//                 .AddDbContext<BeMyGuestContext>(options => options
//                 .UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));

//             services.AddIdentity<ApplicationUser, IdentityRole>()
//                 .AddEntityFrameworkStores<BeMyGuestContext>()
//                 .AddDefaultTokenProviders();

//             services.Configure<IdentityOptions>(options =>
//             {
//                 options.Password.RequireDigit = false;
//                 options.Password.RequiredLength = 0;
//                 options.Password.RequireLowercase = false;
//                 options.Password.RequireNonAlphanumeric = false;
//                 options.Password.RequireUppercase = false;
//                 options.Password.RequiredUniqueChars = 0;
//             });
//         }

//         // public void Configure(IApplicationBuilder app)
//         // {
//         //     app.UseStaticFiles();

//         //     app.UseDeveloperExceptionPage();

//         //     app.UseAuthentication();

//         //     app.UseMvc(routes =>
//         //     {
//         //         routes.MapRoute(
//         //         name: "default",
//         //         template: "{controller=Home}/{action=Index}/{id?}");
//         //     });

//         //     app.Run(async (context) =>
//         //     {
//         //         await context.Response.WriteAsync("Something went wrong!");
//         //     });
//         // }
//         public void Configure(IApplicationBuilder app, IHostingEnvironment env)
//         {
//             if (env.IsDevelopment())
//             {
//                 app.UseDeveloperExceptionPage();
//             }
//             else
//             {
//                 app.UseExceptionHandler("/Home/Error");
//                 // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//                 app.UseHsts();
//             }

//             //app.UseHttpsRedirection();
//             app.UseStaticFiles();
//             app.UseCookiePolicy();

//             app.UseMvc(routes =>
//             {
//                 routes.MapRoute(
//                     name: "default",
//                     template: "{controller=Home}/{action=Index}/{id?}");
//             });
//         }
//     }
// }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BeMyGuest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}