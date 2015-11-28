using Microsoft.AspNet.Builder;
using Microsoft.AspNet.StaticFiles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace StaticPage
{
    public class Startup
    {
        // public Startup(IHostingEnvironment env)
        // {
        //     // Set up configuration sources.
        //     var builder = new ConfigurationBuilder()
        //         .AddJsonFile("appsettings.json")
        //         .AddEnvironmentVariables();
        //     Configuration = builder.Build();
        // }

        // public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDirectoryBrowser();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            // loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            // loggerFactory.AddDebug();

            // if (env.IsDevelopment())
            // {
            //     app.UseDeveloperExceptionPage();
            // }
            // else
            // {
            //     app.UseExceptionHandler("error.html");
            // }

            // app.UseIISPlatformHandler();
            // app.UseStaticFiles();
            // app.UseWelcomePage("/welcome");
            // app.UseRuntimeInfoPage(); // default path is /runtimeinfo
            // app.UseFileServer(new FileServerOptions()
            // {
            //     EnableDirectoryBrowsing = true,
            // });
            // Displays all log levels
            //factory.AddConsole(LogLevel.Verbose);

            app.UseFileServer(new FileServerOptions()
            {
                EnableDirectoryBrowsing = true,
            });

        }

        // Entry point for the application.
        public static void Main(string[] args) => Microsoft.AspNet.Hosting.WebApplication.Run<Startup>(args);
    }
}
