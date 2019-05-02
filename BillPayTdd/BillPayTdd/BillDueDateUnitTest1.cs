using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BillPayTdd
{
    [TestFixture]
    class BillDueDateUnitTest1
    {
        [Test]
        public void ifBussinessDay_ReturnDueDate()
        {
            DateTime input = new DateTime(2018, 8, 6);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = input;
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ifSaturday_ReturnMonday()
        {
            DateTime input = new DateTime(2019, 5, 4);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = new DateTime(2019, 5, 6);
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ifSunday_ReturnMonday()
        {
            DateTime input = new DateTime(2019, 5, 5);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = new DateTime(2019, 5, 6);
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ifHoliday_ReturnNonHoliday()
        {
            DateTime input = new DateTime(2018, 8, 3); // Friday
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = new DateTime(2018, 8, 6);
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ifHoliday_ReturnWeekday()
        {
            DateTime input = new DateTime(2018, 8, 3); // Tuesday 12/15  or Friday 8/3
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = new DateTime(2018, 8, 6);
            Assert.AreEqual(expected, output);
        }
    }
}
