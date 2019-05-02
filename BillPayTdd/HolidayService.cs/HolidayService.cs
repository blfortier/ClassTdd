using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPayTdd
{
    public class HolidayService : IHolidayService
    {
        public bool isHoliday(DateTime dueDate)
        {
            var holidays = new List<DateTime>();
            holidays.Add(new DateTime(2018, 12, 25));
            holidays.Add(new DateTime(2018, 8, 3));

            if (holidays.Contains(dueDate))
                return true;

            return false;
        }
    }
}
