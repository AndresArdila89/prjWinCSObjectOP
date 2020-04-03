using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCSObjectOP
{
    class clsTime
    {
        //Public properties

        private Int16 vHour;
        private Int16 vMinutes;
        private Int16 vSeconds;


        //public properties as a function to be able to do validation

        public Int16 Hour
        {
            get
            {
                return vHour;
            }
            set
            {
                vHour = value;
            }
        }




        //Public Methods or functions

        public string ToUniversal()
        {
            string info = $"{vHour}:{vMinutes}:{vSeconds}";
            return info;
        }

        public string ToStandard()
        {
            string dayNight;
            Int16 fixHour = 0;
            if (Hour >= 12)
            {
                dayNight = "PM";
                fixHour = ((Hour > 12) ? (Int16)(Hour - 12) : Hour);
            }
            else
            {
                dayNight = "AM";
                fixHour = Hour;
            }

            string info = $"{fixHour}:{vMinutes}:{vSeconds} {dayNight}";
            return info;
        }

        public void Adjust(string aHour, string aMinute, string aSecond)
        {
            vHour = Convert.ToInt16(aHour);
            vMinutes = Convert.ToInt16(aMinute);
            vSeconds = Convert.ToInt16(aSecond);
        }
    }
}
