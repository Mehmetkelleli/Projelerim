using Fashion.Business.Abstract;
using Fashion.Business.Concrete;
using Fashion.Data.Abstract;
using Fashion.Data.Concrete;
using Fashion.Functions;
using Fashion.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fashion
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
            services.AddDbContext<UserDbContext>(options => options.UseSqlServer("Server=DESKTOP-3DP2PDF;Database=FashionShop;MultipleActiveResultSets=true;Integrated Security=True"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<UserDbContext>().AddDefaultTokenProviders();
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
                options.AccessDeniedPath = "/account/accesdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".datadb.Cookie"
                };

            });

            //mail sender 
            services.AddScoped<ISenderMail, SenderMail>();
            //dependency enject data
            services.AddScoped<IProductRepository, EfProductRepository>();
            services.AddScoped<ICategoryRepository, EfCategoryRepository>();
            services.AddScoped<IMainCategoryRepository, EfMainCategoryRepository>();
            services.AddScoped<IProductSizeRepository, EfProductSize>();
            services.AddScoped<IHomePageSliderRepository, EfHomePageSliderRepository>();
            services.AddScoped<ISiteConfigRepository, EfSiteConfigRepository>();
            services.AddScoped<IColorRepository, EfColorRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            //dependency enject business
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<IMainCategoryService, MainCategoryManager>();
            services.AddScoped<IProductSizeService, ProductSizeManager>();
            services.AddScoped<IHomePageSliderService, HomePageSliderManager>();
            services.AddScoped<ISiteConfigService, SiteConfigManager>();
            services.AddScoped<IColorService, ColorManager>();
            services.AddScoped<ICartService, CartManager>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(
                //    name : "RoleList",
                //    pattern :"/Root/Roles/",
                //    defaults: new {controller="Root",action="RoleList"}
                //    );
                //endpoints.MapControllerRoute(
                //    name: "RoleCreate",
                //    pattern: "/Root/Roles/Create",
                //    defaults: new { controller = "Root", action = "RoleCreate" }
                //    );
                //endpoints.MapControllerRoute(
                //    name: "RoleUpdate",
                //    pattern: "/Root/Role/Edit/{id?}",
                //    defaults: new { controller = "Root", action = "RoleEdit" }
                //    );
                endpoints.MapControllerRoute(
                   name:"UserList",
                   pattern:"/Root/User/List/",
                   defaults: new { controller = "Root", action ="UserList"}
                    );
                endpoints.MapControllerRoute(
                   name: "UserEdit",
                   pattern: "/Root/User/Edit/",
                   defaults: new { controller = "Root", action = "UserEdit" }
                    );
                endpoints.MapControllerRoute(
                   name: "MainCategoryDelete",
                   pattern: "/Root/MainCategory/Delete/{id?}",
                   defaults: new { controller = "Root", action = "MainCategoryDelete" }
                   );
                endpoints.MapControllerRoute(
                   name: "MainCategoryEdir",
                   pattern: "/Root/MainCategory/Edit/{id?}",
                   defaults: new { controller = "Root", action = "MainCategoryEdit" }
                   );
                endpoints.MapControllerRoute(
                   name: "MainCategoryAdd",
                   pattern: "/Root/MainCategory/Add/",
                   defaults: new { controller = "Root", action = "MainCategoryAdd" }
                   );
                endpoints.MapControllerRoute(
                   name: "MainCategoryList",
                   pattern: "/Root/MainCategories/",
                   defaults: new { controller = "Root", action = "MainCategoryList" }
                   );
                endpoints.MapControllerRoute(
                    name: "ProductDelete",
                    pattern: "/Root/Products/Delete/{url?}",
                    defaults: new { controller = "Root", action = "ProductDelete" }
                    );
                endpoints.MapControllerRoute(
                    name: "AdminProductEdit",
                    pattern: "/Root/Products/Edit/{url?}",
                    defaults: new { controller = "Root", action = "ProductEdit" }
                    );
                endpoints.MapControllerRoute(
                    name: "AdminProductAdd",
                    pattern: "/Root/Product/Add/",
                    defaults: new { controller = "Root", action = "ProductAdd" }
                    );
                endpoints.MapControllerRoute(
                    name: "AdminProductList",
                    pattern: "/Root/Products/",
                    defaults: new { controller = "Root", action = "ProductList" }
                    );
                endpoints.MapControllerRoute(
                    name: "ProductList",
                    pattern:"/Product/{url?}",
                    defaults: new {controller="Shop",action="Details"}
                    );
                endpoints.MapControllerRoute( 
                    name: "ProductwidthCategoriesList",
                    pattern: "/Products/{url?}",
                    defaults:new {controller="Shop",action="List"}

                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
