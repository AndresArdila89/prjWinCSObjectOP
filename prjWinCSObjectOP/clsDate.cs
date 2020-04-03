using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCSObjectOP
{
    class clsDate
    {
        private Int16 varDay;
        private Int16 varMonth;
        private Int16 varYear;

        public Int16 Day
        {
            get
            {
                return varDay;
            }
            set
            {
                varDay = (value > 0 && value < 32) ? value : (Int16)DateTime.Today.Day;
            }
        }

        public Int16 Month
        {
            get
            {
                return varMonth;
            }
            set
            {
                varMonth = (value > 0 && value < 13) ? value : (Int16)DateTime.Today.Month;
            }
        }

        public Int16 Year
        {
           get
            {
                return varYear;
            }

            set
            {
                varYear = (value > 0) ? value : (Int16)DateTime.Today.Year;
            }
        }

        public void Initialize(Int16 iDay, Int16 iMonth, Int16 iYear)
        {
            Day = iDay;
            Month = iMonth;
            Year = iYear;
        }

        public String ToShortDate()
        {
            return $"{Day}/{Month}/{Year}";
        }

        public String ToLongDate()
        {
            String info;
            String[] tabDays = { "Sunday","Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            DateTime tmp = new DateTime(Year, Month, Day);
            info = tabDays[Convert.ToInt32(tmp.DayOfWeek)];
            //finish the month and year
            return info;
        }



    }
}
