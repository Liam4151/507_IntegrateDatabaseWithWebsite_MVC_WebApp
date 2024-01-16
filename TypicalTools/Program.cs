using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TypicalTools.Models;

namespace TypicalTools
{
    // Runs program
    public class Program
    {
        public static void Main(string[] args)
        {
            // Builds and runs application
            CreateHostBuilder(args).Build().Run();
        }

        // Creates Host Builder
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                
                // Starts application up on web
                    webBuilder.UseStartup<Startup>());
    }
}