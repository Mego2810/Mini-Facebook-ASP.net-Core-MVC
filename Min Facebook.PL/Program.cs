using Microsoft.EntityFrameworkCore;
using Min_Facebook.DAL.Contexts;
using Microsoft.AspNetCore.Identity;
using Min_Facebook.DAL.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Min_Facebook.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Add DbContext with SQL Server provider.
            builder.Services.AddDbContext<MinFbDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("CS"));
            }, ServiceLifetime.Singleton);

            // Configure Identity with default user and role classes.
            builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<MinFbDbContext>(); // Use MinFbDbContext as the data store for Identity.

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication(); // Enable authentication middleware.
            app.UseAuthorization(); // Enable authorization middleware.
            app.MapRazorPages();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
