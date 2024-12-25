using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Educational
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();  // HTTP Strict Transport Security (HSTS) for production
            }

            app.UseHttpsRedirection();  // Redirect HTTP to HTTPS
            app.UseStaticFiles();       // Enable static files

            app.UseRouting();           // Routing middleware

            app.UseAuthorization();      // Authorization middleware

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");  // Default route

            app.Run();  // Run the application
        }
    }
}
