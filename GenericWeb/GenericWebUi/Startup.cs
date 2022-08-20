using GenericWeb.Data.Abstract;
using GenericWeb.Data.Concrete;
using GenericWeb.Data.Context;
using GenericWeb.Entity;
using GenericWebUi.Functions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace GenericWebUi
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
            
            
            // datacontext add ýdentity one in two and ýdentity User
            services.AddDbContext<DataContext>(options => options.UseSqlServer("Server=DESKTOP-3DP2PDF;Database=GenericWeb;MultipleActiveResultSets=true;Integrated Security=True"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DataContext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                //add ýdentity options
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 10;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                // Lockout
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(20);
                options.Lockout.AllowedForNewUsers = false;
                //sýgn in options
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.User.RequireUniqueEmail = false;


            });
            services.ConfigureApplicationCookie(options =>
            {
                //login road
                options.LoginPath = "/Account/login";
                options.LogoutPath = "/Account/logout";
                options.AccessDeniedPath = "/Account/accessdenied";
                //cookie setting
                options.SlidingExpiration =true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".GenericWeb.Cookie",
                    //csrf token Attack for security
                    SameSite = SameSiteMode.Strict
                };

            });


            //servicess scope added
            services.AddScoped<IMailSender, MailSender>();
            services.AddScoped<IImageSender, ImageSender>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            //authentiaction Add
            app.UseAuthentication();

            app.UseRouting();
            //authorization Add
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
