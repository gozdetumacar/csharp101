using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(DateTime.Now); // günün tarihini getirir.
            System.Console.WriteLine(DateTime.Now.Date);
            System.Console.WriteLine(DateTime.Now.Day);
            System.Console.WriteLine(DateTime.Now.Month);
            System.Console.WriteLine(DateTime.Now.Year);
            System.Console.WriteLine(DateTime.Now.Hour);
            System.Console.WriteLine(DateTime.Now.Minute);
            System.Console.WriteLine(DateTime.Now.Second);

            System.Console.WriteLine(DateTime.Now.DayOfWeek);
            System.Console.WriteLine(DateTime.Now.DayOfYear);

            System.Console.WriteLine(DateTime.Now.ToLongDateString());
            System.Console.WriteLine(DateTime.Now.ToShortDateString());
            System.Console.WriteLine(DateTime.Now.ToLongTimeString());
            System.Console.WriteLine(DateTime.Now.ToShortTimeString());

            System.Console.WriteLine(DateTime.Now.AddDays(2));
            System.Console.WriteLine(DateTime.Now.AddHours(3));
            System.Console.WriteLine(DateTime.Now.AddSeconds(30));
            System.Console.WriteLine(DateTime.Now.AddMonths(5));
            System.Console.WriteLine(DateTime.Now.AddYears(10));
            System.Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //DateTime format
            System.Console.WriteLine(DateTime.Now.ToString("dd")); //day- 5
            System.Console.WriteLine(DateTime.Now.ToString("ddd")); //day- kısa hali - Cmt
            System.Console.WriteLine(DateTime.Now.ToString("dddd")); //day- Cumartesi

            System.Console.WriteLine(DateTime.Now.ToString("MM")); //month-06
            System.Console.WriteLine(DateTime.Now.ToString("MMM")); //month-kısa hali-Haz
            System.Console.WriteLine(DateTime.Now.ToString("MMMM")); //month-Haziran

            System.Console.WriteLine(DateTime.Now.ToString("yy")); //year-21
            System.Console.WriteLine(DateTime.Now.ToString("yyyy")); //year-2021

            //Math Kütüphanesi
            System.Console.WriteLine("*** Math Kütüphanesi***");
            System.Console.WriteLine(Math.Abs(-25)); //25
            System.Console.WriteLine(Math.Sin(10));
            System.Console.WriteLine(Math.Cos(10));
            System.Console.WriteLine(Math.Tan(10));

            System.Console.WriteLine(Math.Ceiling(22.3)); //23 // her zaman yukarı yuvarlar
            System.Console.WriteLine(Math.Round(22.3)); // 22 // verilen değere göre yuvarlar
            System.Console.WriteLine(Math.Round(22.7)); //23
            System.Console.WriteLine(Math.Floor(22.7)); //22 //her zaman aşağı yuvarlar

            System.Console.WriteLine(Math.Max(2,6));
            System.Console.WriteLine(Math.Min(2,6));

            System.Console.WriteLine(Math.Pow(3,4)); //3^4 = 81
            System.Console.WriteLine(Math.Sqrt(9));  // karekök = 3
            System.Console.WriteLine(Math.Log(9)); //9un e tabanındaki logaritmik karşılığı
            System.Console.WriteLine(Math.Exp(3)); // e üzeri 3
            System.Console.WriteLine(Math.Log10(10)); // 10 sayısının log 10 tabanındaki karşılığı

        }
    }
}
