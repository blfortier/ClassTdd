using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPayTdd
{
    public class Bill
    {
        HolidayService Holiday;
        //bring in holiday service to check for holidays
        //use dependency injection

        public Bill(HolidayService holiday)
        {
            this.Holiday = holiday;
        }

        public DateTime CheckDate(DateTime dueDate)
        {
            if (dueDate.DayOfWeek == DayOfWeek.Saturday)
                return dueDate.AddDays(2);
            if (dueDate.DayOfWeek == DayOfWeek.Sunday)
                return dueDate.AddDays(1);
            if (Holiday.isHoliday(dueDate))
            {
                if (dueDate.DayOfWeek != DayOfWeek.Friday)
                    return dueDate.AddDays(1);
                else
                    return dueDate.AddDays(3);
            }
            return dueDate;
        }
    }
}
