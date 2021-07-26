using System.ComponentModel.DataAnnotations;
using System.Linq;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;

namespace CountItMVC.Infrastructure.Repositories
{
    class DayRepository : IDayRepository
    {
        private readonly Context _context;
        public DayRepository(Context context)
        {
            _context = context;
        }
        public int AddDay(Day day)
        {
            if(!_context.Days.Contains(day))
            {
                _context.Days.Add(day);
                _context.SaveChanges();
                return day.Id;
            }
            return -1;
        }

        public void DeleteDay(int dayId)
        {
            var item = _context.Days.Find(dayId);
            if (item != null)
            {
                _context.Days.Remove(item);
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
    }
}
