using System;
public struct Clock
{
    public int totalMins;
    public Clock(int hours, int minutes)
    {
        totalMins = hours * 60;
        totalMins += minutes;
        int MinutesInADay = 60 * 24;
        totalMins = (totalMins % MinutesInADay + MinutesInADay) % MinutesInADay;
    }
    public int Hours
    {
        get
        {
            return totalMins / 60;
        }
    }
    public int Minutes
    {
        get
        {
            return totalMins % 60;
        }
    }
    public Clock Add(int minutesToAdd)
    {
        return new Clock(0, totalMins + minutesToAdd);
    }
    public Clock Subtract(int minutesToSubtract)
    {
        return new Clock(0, totalMins - minutesToSubtract);
    }
    public override string ToString()
    {
        return String.Format("{0:d2}:{1:d2}", Hours, Minutes);
    }
    public void CheckOverDay()
    {
    }
}