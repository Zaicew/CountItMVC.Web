using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;

namespace CountItMVC.Infrastructure.Repositories
{
    public class DayRepository : IDayRepository
    {
        private readonly Context _context;
        public DayRepository(Context context)
        {
            _context = context;
        }
        public int AddDay(Day day)
        {
                _context.Days.Add(day);
                _context.SaveChanges();
                return day.Id;
        }
        public void DeleteDay(int dayId)
        {
            var day = _context.Days.Find(dayId);
            if (!(day is null))
            {
                _context.Days.Remove(day);
                _context.SaveChanges();
            }
        }
        public IQueryable<Day> GetAllDays()
        {
            return _context.Days;
        }
        public IQueryable<Tag> GetAllTags()
        {
            return _context.Tags;
        }
        public Day GetDayById(int dayId)
        {
            return _context.Days.FirstOrDefault(p => p.Id == dayId);
        }
        //check if below works properly
        public ICollection<Day> GetAllDaysFromCurrentCustomer(int customerId)
        {
            return _context.Customers.Find(customerId).Days;
        }
        public void UpdateDay(Day day)
        {
            _context.Attach(day);
            _context.Entry(day).Property("Date").IsModified = true;
                }
    }
}
