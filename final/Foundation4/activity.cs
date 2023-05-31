using System;
using System.Collections.Generic;

public class Activity
{
    public DateTime _date;
    public int _duration;

    public Activity(DateTime date, int duration)
    {
        this._date = date;
        this._duration = duration;
    }

    public virtual double getDistance()
    {
        return 0;
    }

    public virtual double getSpeed()
    {
        return 0;
    }

    public virtual double getPace()
    {
        return 0;
    }

    public virtual string getSummary()
    {
        return "";
    }
}