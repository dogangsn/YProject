using DataAccess.InversionOfControl.Microsoft;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace WebUI
{
    public class Startup
    {
        public IConfiguration Configration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCustomDependencies();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.Name = "SD_AUTH";
                options.Cookie.SameSite = SameSiteMode.Strict;
                options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                options.ExpireTimeSpan = TimeSpan.FromDays(30);
                options.LoginPath = new PathString("/admin/login/index");
                options.LogoutPath = new PathString("/admin/login/signout");
            });
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddMvc(setupAction => { setupAction.EnableEndpointRouting = false; }).AddJsonOptions(jsonOptions =>
            {
                jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null;
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseAuthentication();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(name: "Admin", pattern: "{area:exists}/{controller=Login}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(name: "urunler", pattern: "tum-urunler", defaults: new { controller = "Products", action = "Products" });
                endpoints.MapControllerRoute(name: "urunDetay", pattern: "urun/{id}/{slug}", defaults: new { controller = "Products", action = "ProductDetail" });
            });
        }
    }
}
