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
        void UpdateDay(NewDayVm model);
        NewDayVm GetDayForEdit(int id);
        void DeleteDay(int dayId);
    }
}
