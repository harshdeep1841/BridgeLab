using System.Globalization;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.DatetimeExplore;

public class DateTimeExp
{
    public static void BuildInFunc()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine(date.Year);
        Console.WriteLine(date.Month);
        Console.WriteLine(date.Day);
        Console.WriteLine(date);
        Console.WriteLine(DateTime.UtcNow);
        Console.WriteLine(DateTime.Today);
        Console.WriteLine(DateTime.MinValue);
        Console.WriteLine(DateTime.MaxValue);
        
        DateTime date1 = new  DateTime(2000, 1, 1);
        DateTime date2 = new  DateTime(2000, 1, 3);
       
        DateTime newdate2 = date2.AddHours(5);
        TimeSpan ts = date1 - newdate2;
        Console.WriteLine(Math.Abs(ts.TotalDays));
        Console.WriteLine(Math.Abs(ts.Days));
        Console.WriteLine(Math.Abs(ts.Hours));
        Console.WriteLine(Math.Abs(ts.Minutes));

        DateTime date3 = DateTime.Parse("03-04-2006");
        Console.WriteLine(date3.Year);
        Console.WriteLine(date3.Month);

        DateTime date4;
        bool dateFormat = DateTime.TryParse("04-05-03", out date4); //by default it will see date-month-year
        Console.WriteLine(date4.Year);
        Console.WriteLine(dateFormat);
        Console.WriteLine(date4.ToString("yyyy//MM//dd"));
        DateTime newdate4 = date4.AddDays(1); //AddDays return a new object of DateTime
        Console.WriteLine(date4);
        Console.WriteLine(newdate4.ToString("yyyy//MM//dd"));

        int compareDate = newdate4.CompareTo(date4); // -1 - > early 0 -> same  1 -> after
        Console.WriteLine(compareDate);
        
        
        DateTime d5 = DateTime.ParseExact(
            "29-07-2026",
            "dd-MM-yyyy",
            CultureInfo.InvariantCulture);
        Console.WriteLine(d5);
        
        DateTimeOffset dateTimeOffset1 = DateTimeOffset.Now;
        Console.WriteLine(dateTimeOffset1);
        DateTime d6 = DateTime.Now;
        Console.WriteLine(d6);
        DayOfWeek dayOfWeek = d6.DayOfWeek;
        Console.WriteLine(dayOfWeek);   
        Console.WriteLine(dateTimeOffset1);



        DateTime utc = DateTime.UtcNow;
        
        TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");  
        
        DateTime tokyoTimeZone = TimeZoneInfo.ConvertTime(utc, timeZoneInfo);
        Console.WriteLine(tokyoTimeZone);
        
    }
    
    
}