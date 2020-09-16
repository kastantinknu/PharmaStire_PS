using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PharmaStire_PS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
            //CreateHostBuilder(args).Build().Run();
            //BuildWebHost(args).Run();
        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    (IHostBuilder)Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); })
        //        .UseDefaultServiceProvider(options => options.ValidateScopes = false)
        //        .Build();
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseDefaultServiceProvider(options => options.ValidateScopes = false)
                .Build();
        //public static IHostBuilder BuildWebHost(string[] args) =>
        //    (IHostBuilder)Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); })
        //        .UseDefaultServiceProvider(options => options.ValidateScopes = false)
        //        .Build();
    }
}