using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Domain.Interface
{
    public interface IDayRepository
    {
        void DeleteDay(int dayId);
        int AddDay(Day day);
        IQueryable<Day> GetAllDays();
        Day GetDayById(int dayId);
        IQueryable<Tag> GetAllTags();
        void UpdateDay(Day day);
        void UpdateDayMacro(Meal meal);
    }
}
