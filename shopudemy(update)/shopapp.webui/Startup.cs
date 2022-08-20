using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using shopapp.business.Abstract;
using shopapp.business.Concrete;
using shopapp.data.Abstract;
using shopapp.data.Concrete;
using shopapp.webui.Identity;

namespace shopapp.webui
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // mvc
            // bu kýsýmda ise business cagýrýlmakta
            services.AddDbContext<UserContext>(options => options.UseMySql("server = localhost; database = newshop; user = root; password = 12345678;"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<UserContext>().AddDefaultTokenProviders();
            // Identity configure add
            services.Configure<IdentityOptions>(options =>
            {
                //password setting
                options.Password.RequiredLength = 10;

                //Lockout
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(20);
                options.Lockout.AllowedForNewUsers = true;

                //cookie user
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;

            });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromHours(1);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name     = ".DataSecurity."
                };
            });

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductService, ProductManager>();

            // bu kýsýmda data cagýrýlmakta business için
            services.AddScoped<IProductRepository, EfProductRepository>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles(); // wwwroot

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                    RequestPath="/modules"                
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            // localhost:5000
            // localhost:5000/home
            // localhost:5000/home/index
            // localhost:5000/product/details/3
            // localhost:5000/product/list/2
            // localhost:5000/category/list

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "Admin-categories",
                   pattern: "Admin/Categories/",
                   defaults: new { controller = "Admin", action = "CategoryList" }
                   );
                endpoints.MapControllerRoute(
                   name: "Admin-product-Create",
                   pattern: "Admin/Product/Add",
                   defaults: new { controller = "Admin", action = "ProductAdd" }
                   );
                endpoints.MapControllerRoute(
                   name: "Admin-category-edit",
                   pattern: "Admin/Category/{id?}",
                   defaults: new { controller = "Admin", action = "CategoryEdit" }
                   );
                endpoints.MapControllerRoute(
                    name: "Admin-product-edit",
                    pattern: "Admin/Product/{id?}",
                    defaults: new {controller="Admin",action="ProductEdit"}
                    );
                endpoints.MapControllerRoute(
                   name: "admin-product-list",
                   pattern: "Admin/Products",
                   defaults: new { controller = "Admin", action = "ProductList" }
                   );
                endpoints.MapControllerRoute(
                   name: "product-search",
                   pattern: "Product/{search?}",
                   defaults: new { controller = "Shop", action = "list" }
                   );
                endpoints.MapControllerRoute(
                    name:"product-detail",
                    pattern:"Product/{url?}",
                    defaults : new {controller="Shop",action="details"}
                    );
                endpoints.MapControllerRoute(
                    name:"Products",
                    pattern:"Products/{category?}",
                    defaults: new {controller="Shop",action="List"}
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
