using System;

public class Date {
    public string GetDay(string date)
    {
        DateOnly date1 = DateOnly.Parse(date);
        string day = date1.DayOfWeek.ToString();
        return day;
    }

    public int GetDaysSpan(int day, int month, int year)
    {
        DateTime date = DateTime.Now;
        DateOnly date1 = DateOnly.FromDateTime(date);
        DateOnly date2 = new DateOnly(year, month, day);
        int span = date2.DayNumber - date1.DayNumber;
        return System.Math.Abs(span);
    }
}
