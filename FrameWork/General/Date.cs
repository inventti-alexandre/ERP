using System;
using System.Globalization;

namespace FrameWork.General
{
    public static class Date
    {
        public static string Getdate(bool isPersian=true)
        {
            var now = DateTime.Now;

            if (isPersian)
            {
                var pc = new PersianCalendar();


                var year = pc.GetYear(now).ToString(CultureInfo.InvariantCulture);

                var month = pc.GetMonth(now).ToString(CultureInfo.InvariantCulture);
                if (month.Length == 1) month = string.Format("0{0}", month);

                var day = pc.GetDayOfMonth(now).ToString(CultureInfo.InvariantCulture);
                if (day.Length == 1) day = string.Format("0{0}", day);


                return $"{year}/{month}/{day}";
            }
            else
            {
                return $"{now.Year}/{now.Month}/{now.Day}";
            }
           
        }
    }
}