using CountItMVC.Domain.Interface;
using CountItMVC.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IContactDetailRepository, ContactDetailRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IDayRepository, DayRepository>();
            services.AddTransient<IItemInMealRepository, ItemInMealRepository>();
            services.AddTransient<IItemRepository, ItemRepository>();
            services.AddTransient<IMealRepository, MealRepository>();

            return services;
        }
    }
}
