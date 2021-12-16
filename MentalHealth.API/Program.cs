using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Logging;
using Microsoft.Extensions.DependencyInjection;
using MentalHealth.DAL;
using Microsoft.EntityFrameworkCore;

namespace MentalHealth.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            IdentityModelEventSource.ShowPII = true;
            
            var host = CreateHostBuilder(args).Build();

            await MigrateAsync(host);

            await host.RunAsync();
        }

        private static async Task MigrateAsync(IHost host)
        {
            using var scope = host.Services.CreateScope();
            var environment = scope.ServiceProvider.GetRequiredService<IHostEnvironment>();
            await using var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            await context.Database.MigrateAsync();

            var demoData = new DemoData();
            context.AddRange(demoData.Roles);
            context.AddRange(demoData.Users);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
