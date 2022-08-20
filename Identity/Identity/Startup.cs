using Identity.EMailSender;
using Identity.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity
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
            // Servicess Scoped
            services.AddScoped<IEMailSender, EFMailSender>();

            // ýdentity added
            services.AddDbContext<UserContext>(options => options.UseSqlServer("Server=DESKTOP-3DP2PDF;Database=IdentityData;Integrated Security=True"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<UserContext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                //password 
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 10;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                //lockout
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                options.Lockout.AllowedForNewUsers = true;
                //options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;

            });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/Login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account//accesdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".datadb.Cookie"
                };
            });

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

            // yetki saglama aktif edildi
            app.UseAuthentication();
            //routing iþlemi yapýlmakta;
            app.UseRouting();


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
