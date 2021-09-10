using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CountItMVC.Infrastructure;
using CountItMVC.Application.Interfaces;
using CountItMVC.Application.Services;
using System.Reflection;
using CountItMVC.Domain.Interface;
using CountItMVC.Infrastructure.Repositories;
using CountItMVC.Application;
using FluentValidation.AspNetCore;
using FluentValidation;
using CountItMVC.Application.ViewModels;
using Microsoft.Extensions.Logging;
using CountItMVC.Domain.Model;

namespace CountItMVC.Web
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
            services.AddDbContext<Context>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            //services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            //{
            //    options.Password.RequireDigit = true;
            //    options.Password.RequiredLength = 8;
            //    options.Password.RequireLowercase = true;
            //    options.Password.RequireUppercase = true;
            //    options.Password.RequiredUniqueChars = 1;

            //    options.SignIn.RequireConfirmedAccount = false;
            //    options.User.RequireUniqueEmail = true;
            //}).AddEntityFrameworkStores<Context>();
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<Context>();

            services.AddApplication();
            services.AddInfrastructure();

            services.AddControllersWithViews();
            services.AddControllersWithViews().AddFluentValidation(fv => fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false);

            services.AddTransient<IValidator<NewCategoryVm>, NewCategoryValidation>();
            services.AddTransient<IValidator<NewItemVm>, NewItemValidation>();

            services.AddRazorPages();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredUniqueChars = 1;

                options.SignIn.RequireConfirmedAccount = false;
                options.User.RequireUniqueEmail = true;
            });

            services.AddAuthentication()
                .AddGoogle(options =>
            {
                IConfigurationSection googleAuthNSection = Configuration.GetSection("Authentication:Google");
                options.ClientId = googleAuthNSection["ClientId"];
                options.ClientSecret = googleAuthNSection["ClientSecret"];
            })
                .AddFacebook(options =>
            {
                IConfigurationSection facebookAuthnNSection = Configuration.GetSection("Authentication:Facebook");
                options.ClientId = facebookAuthnNSection["ClientId"];
                options.ClientSecret = facebookAuthnNSection["ClientSecret"];
            })
                .AddTwitter(options =>
            {
                IConfigurationSection twitterAuthNSection = Configuration.GetSection("Authentication:Twitter");
                options.ConsumerKey = twitterAuthNSection["ConsumerKey"];
                options.ConsumerSecret = twitterAuthNSection["ConsumerSecret"];
                options.RetrieveUserDetails = true;
            })
                .AddMicrosoftAccount(options =>
            {
                //IConfigurationSection facebookAuthnNSection = Configuration.GetSection("Authentication:Facebook");
                options.ClientId = "7c78a3c5-5f88-4a9d-bda6-189503ffc0ef";
                options.ClientSecret = "qzRSO53~jA-Vd4.GOrX-5..-r7W.3m3TJU";
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile("Logs/myLog-{Date}.txt");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
