using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Time2
{
        private int hour; // 0 - 23
        private int minute; // 0 - 59
        private int second; // 0 - 59

        private int addhour; // 0 - 23
        private int addminute; // 0 - 59
        private int addsecond; // 0 - 59

        private int hour2; // 0 - 23
        private int minute2; // 0 - 59
        private int second2; // 0 - 59
        private int day2;


        // constructor can be called with zero, one, two or three arguments
        public Time2(int h = 0, int m = 0, int s = 0)
        {
            SetTime(h, m, s); // invoke SetTime to validate time
            addTime(h, m, s);
        } // end Time2 three-argument constructor 

        // Time2 constructor: another Time2 object supplied as an argument
        public Time2(Time2 time)
            : this(time.Hour, time.Minute, time.Second) 
        {
          addtime(time);
        }

        // constructor to add time with three parameters
        public void addTime(int h, int m, int s)
        {
            SetAddTime(h, m, s);

            second2 = Second + Addsecond;
            if(second2 > 59)
            {
                second2 -= 60;
                minute2 += 1;
            }

            minute2 = minute2 + Minute + Addminute;
            if(minute2 > 59)
            {
                minute2 -= 60;
                hour2 += 1;
            }

            hour2 = hour2 + Hour + Addhour;
            if (hour2 > 23)
            {
                int hours = hour2;
                hour2 = hour2%24;
                day2 = hours/24;
            }

        } // end Time2 three-argument overloaded method 

        // Time2 constructor: another Time2 object supplied as an argument
        public void addtime(Time2 atime)
        {
            atime.SetTime(Hour, Minute, Second);
            atime.addTime(Hour, Minute, Second);
        }

        // set a new time value using universal time; ensure that 
        // the data remains consistent by setting invalid values to zero
        public void SetTime(int h, int m, int s)
        {
            Hour = h; // set the Hour property
            Minute = m; // set the Minute property
            Second = s; // set the Second property
        } // end method SetTime

        public void SetAddTime(int h, int m, int s)
        {
            Addhour = h; // set the AddHour property
            Addminute = m; // set the AddMinute property
            Addsecond = s; // set the AddSecond property
        } // end method SetTime

        public void SetTime2(int h, int m, int s)
        {
            Hour2 = h; // set the Hour2 property
            Minute2 = m; // set the Minute2 property
            Second2 = s; // set the Second2 property
        } // end method SetTime

        public void SetTime2WithDay(int d, int h, int m, int s)
        {
            Day2 = d; //set the Day2 property
            Hour2 = h; // set the Hour2 property
            Minute2 = m; // set the Minute2 property
            Second2 = s; // set the Second2 property
        } // end method SetTime

       
        # region Properties - Setters and Getters


        // property that gets and sets the hour
        public int Hour
        {
            get
            {
                return hour;
            } // end get
            set
            {
                if (value >= 0 && value < 24)
                    hour = value;
                else
                    throw new ArgumentOutOfRangeException(
                       "Hour", value, "Hour must be 0-23");
            } // end set
        } // end property Hour

        // property that gets and sets the minute
        public int Minute
        {
            get
            {
                return minute;
            } // end get
            set
            {
                if (value >= 0 && value < 60)
                    minute = value;
                else
                    throw new ArgumentOutOfRangeException(
                       "Minute", value, "Minute must be 0-59");
            } // end set
        } // end property Minute

        // property that gets and sets the second
        public int Second
        {
            get
            {
                return second;
            } // end get
            set
            {
                if (value >= 0 && value < 60)
                    second = value;
                else
                    throw new ArgumentOutOfRangeException(
                       "Second", value, "Second must be 0-59");
            } // end set
        } // end property Second
    
    
    public int Addhour
        {
            get
            {
                return addhour;
            } // end get
            set
            {
                if (value >= 0 && value < 24)
                    addhour = value;
                else
                    throw new ArgumentOutOfRangeException(
                       "Hour2", value, "AddHour must be 0-23");
            } // end set
        } // end property Addhour

        // property that gets and sets the minute
        public int Addminute
        {
            get
            {
                return addminute;
            } // end get
            set
            {
                if (value >= 0 && value < 60)
                    addminute = value;
                else
                    throw new ArgumentOutOfRangeException(
                       "AddMinute", value, "Minute must be 0-59");
            } // end set
        } // end property Addminute

        // property that gets and sets the second
        public int Addsecond
        {
            get
            {
                return addsecond;
            } // end get
            set
            {
                if (value >= 0 && value < 60)
                    addsecond = value;
                else
                    throw new ArgumentOutOfRangeException(
                       "AddSecond", value, "Second must be 0-59");
            } // end set
        } // end property Addecond

        public int Day2
        {
            get
            {
                return day2;
            } // end get
            set
            {
                if (value > 0)
                    day2 = value;
                else
                    throw new ArgumentOutOfRangeException(
                       "Day2", value, "Invalid inputs");
            } // end set
        } // end property Day2
    
        public int Hour2
        {
            get
            {
                return hour2;
            } // end get
            set
            {
                if (value >= 0 && value < 24)
                    hour2 = value;
                else
                    throw new ArgumentOutOfRangeException(
                           "Hour2", value, "Hour2 must be 0-23");
            } // end set
        } // end property Hour2

        // property that gets and sets the minute
        public int Minute2
        {
            get
            {
                return minute2;
            } // end get
            set
            {
                if (value >= 0 && value < 60)
                    minute2 = value;
                else
                    throw new ArgumentOutOfRangeException(
                       "Minute2", value, "Minute2 must be 0-59");
            } // end set
        } // end property Minute2

        // property that gets and sets the second
        public int Second2
        {
            get
            {
                return second2;
            } // end get
            set
            {
                if (value >= 0 && value < 60)
                    second2 = value;
                else
                    throw new ArgumentOutOfRangeException(
                       "Second2", value, "Second2 must be 0-59");
            } // end set
        } // end property Second2

        # endregion

        // convert to string in universal-time format (HH:MM:SS)
        public string ToUniversalString()
        {
            return string.Format(
               "Original Time2 Class:\n\tTime - {0:D2}:{1:D2}:{2:D2}" +
               "\n\tTime to add - {3:D2}:{4:D2}:{5:D2}" +
               "\n\tAfter adding - {6:D2}:{7:D2}:{8:D2}:{9:D2} (DD:HH:MM:SS format)"+
               "", Hour, Minute, Second, Addhour, Addminute, Addsecond, Day2, Hour2, Minute2, Second2);
        } // end method ToUniversalString

        // convert to string in standard-time format (H:MM:SS AM or PM)
        public override string ToString()
        {
            return string.Format("{0}:{1:D2}:{2:D2} {3} Original Time2 Class",
              ((Hour2 == 0 || Hour2 == 12) ? 12 : Hour2 % 12),
              Minute2, Second2, (Hour2 < 12 ? "AM" : "PM"));
        } // end method ToString
    } // end class Time2

    /**************************************************************************
     * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
     * Pearson Education, Inc. All Rights Reserved.                           *
     *                                                                        *
     * DISCLAIMER: The authors and publisher of this book have used their     *
     * best efforts in preparing the book. These efforts include the          *
     * development, research, and testing of the theories and programs        *
     * to determine their effectiveness. The authors and publisher make       *
     * no warranty of any kind, expressed or implied, with regard to these    *
     * programs or to the documentation contained in these books. The authors *
     * and publisher shall not be liable in any event for incidental or       *
     * consequential damages in connection with, or arising out of, the       *
     * furnishing, performance, or use of these programs.                     *
     *************************************************************************/