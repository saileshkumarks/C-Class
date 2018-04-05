using System;

namespace time2tzone
{ 
class time2tz:Time2
{
    private int givenTime;
    public int GivenTime
    {
        get { return givenTime; }
        set { givenTime = value; }
    }

    private int addedtime;

    public int AddedTime
    {
        get { return addedtime; }
        set { addedtime = value; }
    }

    private String timeZone;

    public String TimeZone
    {
        get { return timeZone; }
        set { timeZone = value; }
    }

    private int systemHour;

    public int SystemHour
    {
        get { return systemHour; }
        set { systemHour = value; }
    }


    private int systemMinute;

    public int SystemMinute
    {
        get { return systemMinute; }
        set { systemMinute = value; }
    }

    private int systemSecond;

    public int SystemSecond
    {
        get { return systemSecond; }
        set { systemSecond = value; }
    }

    private int systemTimeSeconds;

    public int SystemTimeSeconds
    {
        get { return systemTimeSeconds; }
        set { systemTimeSeconds = value; }
    }

    private int timeDifference;

    public int TimeDifference
    {
        get { return timeDifference; }
        set { timeDifference = value; }
    }

    private int userTime;

    public int UserTime
    {
        get { return userTime; }
        set { userTime = value; }
    }


    //converting HH:MM:SS into seconds
    public time2tz(int h = 0, int m = 0, int s = 0)
    {
        Hour = h;
        Minute = m;
        Second = s;
        GivenTime = base.Hour * 3600 + base.Minute * 60 + base.Second;
        tzFinder(GivenTime);
    }

    // adding time (passing time in seconds) and then converting the total to seconds
    public time2tz(int addTimeInSeconds, int h = 0, int m = 0, int s = 0)
    {
        Hour = h;
        Minute = m;
        Second = s;
        AddedTime = Hour * 3600 + Minute * 60 + Second + addTimeInSeconds;
        tzFinder(AddedTime);
    }

    public time2tz(int h, int m, int s, int h1, int m1, int s1)
    {
        Hour = h;
        Minute = m;
        Second = s;
        GivenTime = Hour * 3600 + Minute * 60 + Second + s1 + m1 * 60 + h1 * 3600;
        tzFinder(GivenTime);
    }

    public void tzFinder(int timeInSeconds)
    {
        UserTime = timeInSeconds;
        SystemHour = DateTime.Now.Hour;
        SystemMinute = DateTime.Now.Minute;
        SystemSecond = DateTime.Now.Second;
        SystemTimeSeconds = systemHour * 3600 + systemMinute * 60 + systemSecond;
        TimeDifference = systemTimeSeconds - timeInSeconds;
        if (TimeDifference <= 3600)
        {
            TimeZone = "CST";
        }
        else if (TimeDifference <= 7200)
        {
            TimeZone = "MST";
        }
        else if (TimeDifference <= 10800)
        {
            TimeZone = "PST";
        }
        else if (TimeDifference <= -3600)
        {
            TimeZone = "EST";
        }
        else
        {
            TimeZone = "Other";
        }
    }

    public override string ToString()
    {
        return string.Format("Time in seconds {0} {1} {2} {3} {4} {5} New Time 2 Derived Class", UserTime, TimeZone, base.ToString());
    }

    public override string ToUniversalString()
    {
        return string.Format("{0}:{1:D2}:{2:D2} {3} CST New Time2 Derived Class",
          ((Hour2 == 0 || Hour2 == 12) ? 12 : Hour2 % 12),
          Minute2, Second2, (Hour2 < 12 ? "AM" : "PM"));
    }
}
}