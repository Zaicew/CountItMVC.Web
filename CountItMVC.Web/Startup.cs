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
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<Context>();
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IDayService, DayService>();
            services.AddTransient<IItemInMealService, ItemInMealService>();
            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<IMealService, MealService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IContactDetailRepository, ContactDetailRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IDayRepository, DayRepository>();
            services.AddTransient<IItemInMealRepository, ItemInMealRepository>();
            services.AddTransient<IItemRepository, ItemRepository>();
            services.AddTransient<IMealRepository, MealRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

                //endpoints.MapControllerRoute(
                //    name: "itemDetails",
                //    pattern: "Item/ShowDetailsOfChoosenItem/{*id}",
                //    defaults: new { controller = "Item", action = "ShowDetailsOfChoosenItem" });
                //endpoints.MapControllerRoute(
                //    name: "customerDetails",
                //    pattern: "Customer/ViewCustomer/{*id}",
                //    defaults: new { controller = "Customer", action = "ViewCustomer" });
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
