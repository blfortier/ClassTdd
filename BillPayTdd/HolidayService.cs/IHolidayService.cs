﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPayTdd
{
    public interface IHolidayService
    {
        bool isHoliday(DateTime duedate);
    }
}
