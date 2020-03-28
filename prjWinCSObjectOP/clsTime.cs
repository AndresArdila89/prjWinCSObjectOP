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

        public Int16 Hour;
        public Int16 Minutes;
        public Int16 Seconds;

        //Public Methods or functions

        public string ToUniversal()
        {
            string info = $"{Hour}:{Minutes}:{Seconds}";
            return info;
        }

        public void Adjust(Int16 aHour, Int16 aMinute, Int16 aSecond)
        {
            Hour = aHour;
            Minutes = aMinute;
            Seconds = aSecond;
        }
    }
}
