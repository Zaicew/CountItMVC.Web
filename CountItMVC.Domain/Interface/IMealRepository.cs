using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Domain.Interface
{
    public interface IMealRepository
    {
        IQueryable<Meal> GetAllMeals();
    }
}
