using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServicesExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer("Server=DESKTOP-3DP2PDF;Database=YoutubeMiniETicaret;Integrated Security=True;"));
            //services.AddSingleton<>
        }
    }
}
