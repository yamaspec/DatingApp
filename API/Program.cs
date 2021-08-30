using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace API
{
	public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            // using var scope = host.Services.CreateScope();
            // var services = scope.ServiceProvider;
            // try
            // {
            //     var context = services.GetRequiredService<DataContext>();
            //     await context.Database.MigrateAsync();
            //     await Seed.SeedUsers(context);
            // }
            // catch (Exception ex)
            // {
            //     var logger = services.GetRequiredService<ILogger<Program>>();
            //     logger.LogError(ex, "An error occurred");
            // }
            // await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
