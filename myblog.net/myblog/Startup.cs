using blog.businnes.Abstract;
using blog.businnes.Concrete;
using blog.data.Abstract;
using blog.data.Concrete.EfCoreMysql;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myblog
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
            //bu kýsýmda iþ katmaný enfekte iþlemi yapýlmakta
            services.AddScoped<ISettingRepository, EfSettingRepository>();
            services.AddScoped<IPostRepository, EfPostRepository>();
            services.AddScoped<IMyRepository, EfMyRepository>();
            services.AddScoped<ICategoryRepository, EfCategoryrepository>();
            services.AddScoped<IPostRepository, EfPostRepository>();
            services.AddScoped<ICvRepository, EfCvRepository>();
            //bu kýsýmda controllera enfekte iþlemi yapýlmakta
            services.AddScoped<ICatetgoryService, CategoryManager>();
            services.AddScoped<ICvService, CvManager>();
            services.AddScoped<IMyService, MyManager>();
            services.AddScoped<IPostService, PostManager>();
            services.AddScoped<ISettingService, SettingManager>();
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name:"Blog",
                    pattern:"Blog",
                    defaults: new {controller="home",action="blog"}
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
