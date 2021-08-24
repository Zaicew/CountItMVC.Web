using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface IDayService
    {
        int AddDay(NewDayVm model);
        DayDetailVm GetDayById(int id);
        ListDayDetailVm GetAllDaysForList();
    }
}
